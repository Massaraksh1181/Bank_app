using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bank_app.Classes;
using System.Data.SqlTypes;

namespace Bank_app.Forms
{
    public partial class SendToForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();
        CurrencyAPI currencyAPI = new CurrencyAPI();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public SendToForm()
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

        // SqlParameter parameter = new SqlParameter("@Money", SqlDbType.Money);

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendToForm_Load(object sender, EventArgs e)
        {
            TextBoxCardDestination.Text = DataStorage.bankCard;
            TextBoxCard.Text = DataStorage.cardNumber;
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {

            var cardNumber = TextBoxCard.Text;
            var cardCVV = TextBoxCvv.Text;
            var cardDate = TextBoxCardTo.Text;
            var destinationCard = TextBoxCardDestination.Text;
            decimal sum = Convert.ToDecimal(TextBoxSum.Text);
            var cardCurrency = "";
            var cardCurrency2 = ""; 
            var cardCVVCheck = "";
            var cardDateCheck = "";
            decimal cardBalanceCheck = 0;
            bool error = false;

            var queryCheckCard = $"select bank_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT (bank_card_date,'%y'))," +
                $" bank_card_balance, bank_card_currency from bank_card where bank_card_number = '{cardNumber}'";
            SqlCommand commandCheckCard = new SqlCommand(queryCheckCard, database.getConnection());
            database.openConnection();
            SqlDataReader reader = commandCheckCard.ExecuteReader();

            while (reader.Read())
            {
                cardCVVCheck = reader[0].ToString();
                cardDateCheck = reader[1].ToString();
                cardBalanceCheck = Convert.ToDecimal(reader[2].ToString());
                cardCurrency = reader[3].ToString();
            }
            reader.Close();
            database.closeConnection();//

            if (cardCVV != cardCVVCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введен CVV-код","Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;

            }

            if (cardDate != cardDateCheck)
            {
                MessageBox.Show("Ошибка. Некорректно введена дата карты", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            var queryCheckCardNumber = $"select id_bank_card, bank_card_currency from bank_card where bank_card_number ='{destinationCard}'";
            SqlCommand commandCheckCardNumber = new SqlCommand(queryCheckCardNumber, database.getConnection());
            database.openConnection();//
            adapter.SelectCommand = commandCheckCard;
            adapter.Fill(table);
            SqlDataReader reader1 = commandCheckCardNumber.ExecuteReader();
            while (reader1.Read())
            {
                cardCurrency2 = reader1[1].ToString();
            }
            reader.Close();
            database.closeConnection();

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Ошибка. Неверные данные карты получателя", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (Convert.ToDouble(sum)<1.00)
            {
                MessageBox.Show("Ошибка. Минимальная сумма перевода 1.00 RUB", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (cardNumber == destinationCard)
            {
                MessageBox.Show("Ошибка. Вы не можите перевести средства на эту карту", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (sum > cardBalanceCheck)
            {
                MessageBox.Show("Недостаточно средств для совершения операции", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }

            if (error == false)
            {
                DataStorage.bankCard = TextBoxCard.Text;
                Validation validation = new Validation();
                validation.ShowDialog();

                if (DataStorage.attemps>0)
                {
                    DateTime transactionDateDate = DateTime.Now;
                    string transactionDate = transactionDateDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    var transactionNumber = "p";
                    for (int i=0;i<10;i++)
                    {
                        transactionNumber += Convert.ToString(rand.Next(0,10));
                    }
                    var queryTransaction1 = $"";
                    var queryTransaction2 = $"";
 
                    queryTransaction1 = $"update bank_card set bank_card_balance = bank_card_balance - '{sum}' where bank_card_number = '{cardNumber}'";
                    queryTransaction2 = $"update bank_card set bank_card_balance = bank_card_balance + '{sum*currencyAPI.getCurrency(cardCurrency, cardCurrency2)}' where bank_card_number = '{destinationCard}'";
 
                    var queryTransaction3 = $"insert into transactions (transaction_type, transaction_destination, transaction_date, transaction_number, transaction_value, id_bank_card) values ('Перевод', '{destinationCard}', '{transactionDate}','{transactionNumber}','{sum}', (select id_bank_card from bank_card where bank_card_number = '{cardNumber}'))";
                    var command1 = new SqlCommand(queryTransaction1, database.getConnection());
                    var command2 = new SqlCommand(queryTransaction2, database.getConnection());
                    var command3 = new SqlCommand(queryTransaction3, database.getConnection());
                    database.openConnection();
                    command1.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    database.closeConnection();

                    Close();

                }
            }
        }
    }
}
