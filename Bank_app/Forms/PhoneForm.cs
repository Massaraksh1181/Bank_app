using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_app.Classes;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Bank_app.Forms
{
    public partial class PhoneForm : Form
    {

        DataBaseConnection dataBase = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public PhoneForm()
        {
            InitializeComponent();
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        protected override void WndProc(ref Message message)// претаскивание окна из любого места
        {
            if (message.Msg == 0x201)
            {
                base.Capture = false;
                message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            }
            base.WndProc(ref message);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            string tmp = textBoxNumber.Text;
            string phoneNumberToCheck = String.Concat(tmp[0], tmp[1], tmp [2]);

            string selectedOperator = comboBoxOperator.GetItemText(comboBoxOperator.SelectedItem);

            bool numberChek = false;

            if (selectedOperator == "Теле2")
            {
                if (phoneNumberToCheck != "900" && phoneNumberToCheck != "902" && phoneNumberToCheck != "904" && phoneNumberToCheck != "908" && phoneNumberToCheck != "950")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberChek = true;
                    return;
                }
            }
            else if (selectedOperator == "Мегафон")
            {
                for (int i=920;i<=938;i++)
                { 
                    if (phoneNumberToCheck != Convert.ToString(i))
                    {
                        MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                        numberChek = true;
                        return;
                    }
                }
            }
            else if (selectedOperator == "Билайн")
            {
                if (phoneNumberToCheck != "903" && phoneNumberToCheck != "905" && phoneNumberToCheck != "906" && phoneNumberToCheck != "909" && phoneNumberToCheck != "960")
                {
                    MessageBox.Show("Введите корректный номер телефона.", caption, btn, ico);
                    numberChek = true;
                    return;
                }
            }

            if (numberChek == false)
            {
                var phoneNumber = textBoxNumber.Text;
                double sum = Convert.ToDouble(textBoxSum.Text);
                var cardNumber = label_cardNumber.Text;
                var cardCVV = TextBoxCvv.Text;
                var cardDate = TextBoxCardTo.Text;
                var cardCVVCheck = "";
                var cardDateCheck = "";
                double cardBalanceCheck=0;
                bool error = false;
                string cardCurrency = "";

                double comission = ((Convert.ToDouble(sum)*2)/100);
                double totalSum = comission + Convert.ToDouble(sum);

                if (!Regex.IsMatch(textBoxNumber.Text, "^[0-9]{10}$"))
                {
                    MessageBox.Show("Введите корректный номер телефона", caption, btn, ico);
                    textBoxNumber.Select();
                    return;
                }

                var queryCheckCard =  $"select bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{cardNumber}'";
                SqlCommand commandCheckCard = new SqlCommand(queryCheckCard, dataBase.getConnection());
                dataBase.openConnection();  
                SqlDataReader reader = commandCheckCard.ExecuteReader();
                while (reader.Read())
                {
                    cardCVVCheck = reader[0].ToString();
                    cardDateCheck = reader[1].ToString();
                    cardBalanceCheck = Convert.ToDouble(reader[2].ToString());
                    cardCurrency = reader[3].ToString();
                }
                reader.Close();

                if (cardCurrency!= "RUB")
                {
                    MessageBox.Show("Пополнение мобильного может происходить только в рублях!", "Отмена", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    error = true;
                }
                if (cardCVV != cardCVVCheck)
                {
                    MessageBox.Show("Некорректно введен CVV-код!", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }
                if (cardDate != cardDateCheck)
                {
                    MessageBox.Show("Некорректно введена дата карты!", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }
                if (Convert.ToDouble(sum)<10.00)
                {
                    MessageBox.Show("Минимальная сумма пополнения 10 рублей", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }
                if (sum > cardBalanceCheck)
                {
                    MessageBox.Show("Недостаточно средств для совершения операции!", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error = true;
                }

                if (error==false)
                {
                    DataStorage.bankCard = label_cardNumber.Text;
                    Validation validation = new Validation();
                    validation.ShowDialog();

                    if (DataStorage.attemps>0)
                    {
                        DateTime dateTime = DateTime.Now;
                        string transactionDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        var transactionNumber = "P";

                        for (int i=0; i<10; i++)
                        {
                            transactionNumber += Convert.ToString(rand.Next(0, 10));
                        }
                        var queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{totalSum}' where bank_card_number = '{cardNumber}'";
                        var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values ('Пополнение мобильного', '+7{textBoxNumber.Text}','{transactionDate}','{transactionNumber}', '{totalSum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";
                        var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance +'{sum}' where serviceName = '{comboBoxOperator.GetItemText(comboBoxOperator.SelectedItem)}' and serviceType = 'Mobile'";

                        var command1 = new SqlCommand(queryTransaction1, dataBase.getConnection());
                        var command2 = new SqlCommand(queryTransaction2, dataBase.getConnection());
                        var command3 = new SqlCommand(queryTransaction3, dataBase.getConnection());

                        dataBase.openConnection();

                        command1.ExecuteNonQuery();
                        command2.ExecuteNonQuery();
                        command3.ExecuteNonQuery();

                        dataBase.closeConnection();

                        Close();
                    }    
                }

            }
        } 

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            textBoxNumber.Text = DataStorage.phoneNumber;
            label_cardNumber.Text = DataStorage.cardNumber;

            var queryChooseOperator = $"select id_service, serviceName from clientServices where serviceType = 'Mobile'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, dataBase.getConnection());
            dataBase.openConnection();
            DataTable operators = new DataTable();
            commandChooseOperator.Fill(operators);
            comboBoxOperator.DataSource = operators;
            comboBoxOperator.ValueMember = "id_service";
            comboBoxOperator.DisplayMember = "serviceName";
            dataBase.closeConnection();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            if(textBoxSum.Text == string.Empty)
            {
                textBoxSum.Text = null;
                labelCommission.Text = "0";
                labelTotalSum.Text = "0";
            }    
            else
            {
                double sum = Convert.ToDouble(textBoxSum.Text);
                labelCommission.Text = Convert.ToString((sum * 2) / 100);
                labelTotalSum.Text = Convert.ToString(((sum * 2) / 100) + sum);
            }
        }
    }
}
