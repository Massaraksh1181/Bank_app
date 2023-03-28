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
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Bank_app.Forms
{
    public partial class InternetAndTvPayments : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public InternetAndTvPayments()
        {
            InitializeComponent();
        }

        private void InternetAndTvPayments_Load(object sender, EventArgs e)
        {
            label_cardNumber.Text = DataStorage.cardNumber;

            var queryChooseOperator = $"select id_service, serviceName from clientServices where serviceType = 'Internet'";
            SqlDataAdapter commandChooseOperator = new SqlDataAdapter(queryChooseOperator, dataBase.getConnection());
            dataBase.openConnection();
            DataTable operators = new DataTable();
            commandChooseOperator.Fill(operators);
            comboBoxInternetAndTvPayments.DataSource = operators;
            comboBoxInternetAndTvPayments.ValueMember = "id_service";
            comboBoxInternetAndTvPayments.DisplayMember = "serviceName";
            dataBase.closeConnection();
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
            var PersonalAccount = textBoxPersonalAccount.Text;
            double sum = Convert.ToDouble(textBoxSum.Text);
            var cardNumber = label_cardNumber.Text;
            var cardCVV = TextBoxCvv.Text;
            var cardDate = TextBoxCardTo.Text;
            var cardCVVCheck = "";
            var cardDateCheck = "";
            double cardBalanceCheck = 0;
            bool error = false;
            string cardCurrency = "";

            if (!Regex.IsMatch(textBoxPersonalAccount.Text, "^[0-9]{10}$"))
            {
                MessageBox.Show("Введите корректный номер лицевого счета", caption, btn, ico);
                textBoxPersonalAccount.Select();
                return;
            }

            var queryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT(bank_card_date, '%y')), bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{cardNumber}'";
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

            if (cardCurrency != "RUB")
            {
                MessageBox.Show("Оплата коммунальных услуг может происходить только в рублях!", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (Convert.ToDouble(sum) < 10.00)
            {
                MessageBox.Show("Минимальная сумма пополнения 10 рублей", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }
            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Недостаточно средств для совершения операции!", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (error == false)
            {
                DataStorage.bankCard = label_cardNumber.Text;
                Validation validation = new Validation();
                validation.ShowDialog();

                if (DataStorage.attemps > 0)
                {
                    DateTime dateTime = DateTime.Now;
                    string transactionDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    var transactionNumber = "P";

                    for (int i = 0; i < 10; i++)
                    {
                        transactionNumber += Convert.ToString(rand.Next(0, 10));
                    }
                    var queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance -'{sum}' where bank_card_number = '{cardNumber}'";
                    var queryTransaction2 = $"insert into transactions(transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values ('Оплата интернета и телевидения', '{comboBoxInternetAndTvPayments.GetItemText(comboBoxInternetAndTvPayments.SelectedItem)}','{transactionDate}','{transactionNumber}', '{sum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";
                    var queryTransaction3 = $"update clientServices set serviceBalance = serviceBalance +'{sum}' where serviceName = '{comboBoxInternetAndTvPayments.GetItemText(comboBoxInternetAndTvPayments.SelectedItem)}' and serviceType = 'Internet'";
                    var queryTransaction4 = $"insert into clientPersonalAccount(personal_account, id_service, id_client) values ('{textBoxPersonalAccount.Text}', (select id_service from clientServices where serviceName = '{comboBoxInternetAndTvPayments.GetItemText(comboBoxInternetAndTvPayments.SelectedItem)}' and serviceType = 'Internet'), '{DataStorage.idClient}')";

                    var command1 = new SqlCommand(queryTransaction1, dataBase.getConnection());
                    var command2 = new SqlCommand(queryTransaction2, dataBase.getConnection());
                    var command3 = new SqlCommand(queryTransaction3, dataBase.getConnection());
                    var command4 = new SqlCommand(queryTransaction4, dataBase.getConnection());

                    dataBase.openConnection();

                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    command4.ExecuteNonQuery();

                    dataBase.closeConnection();

                    Close();
                }
            }
        }
    }
}
