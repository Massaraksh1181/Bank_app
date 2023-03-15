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

namespace Bank_app.Forms
{
    public partial class AddBankCard : Form
    {

        DataBaseConnection dataBase = new DataBaseConnection();
        Random rand = new Random();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        public AddBankCard()
        {
            InitializeComponent();
        }

        private void AddBankCard_Load(object sender, EventArgs e)
        {
            cardTypeComboBox.SelectedIndex = 0;
            currencyComboBox.SelectedIndex = 0;
            paymentSystemComboBox.SelectedIndex = 0;
        }

        private void addCardButton_Click(object sender, EventArgs e)
        {
            var cardType = cardTypeComboBox.GetItemText(cardTypeComboBox.SelectedItem);
            var currency = currencyComboBox.GetItemText(currencyComboBox.SelectedItem);
            var paymentSystem = paymentSystemComboBox.GetItemText(paymentSystemComboBox.SelectedItem);
            var cardNumber = "";
            var cardPin = numericUpDownPin.Value;
            var cvvCode = "";
            bool isCardFree = false;
            DateTime dateTime = DateTime.Now;
            dateTime = dateTime.AddYears(4);
            string  cardDate = dateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            for (int i = 0; i < 3; i++)
            {
                cvvCode += Convert.ToString(rand.Next(0, 10));
            }

            do
            {
                if (paymentSystem == "Visa")
                {
                    cardNumber += "4";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }
                else
                {
                    cardNumber += "5";
                    for (int i = 0; i < 15; i++)
                    {
                        cardNumber += Convert.ToString(rand.Next(0, 10));
                    }
                }

                var queryCheckCardNumber = $"select * from bank_card where bank_card_number = '{cardNumber}'";
                SqlCommand command = new SqlCommand(queryCheckCardNumber, dataBase.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    isCardFree = true;
                }
            } while (isCardFree == false);

            var queryAddNewCard = $"insert into bank_card(bank_card_type, bank_card_number, bank_card_cvv_code, bank_card_currency,bank_card_paymentSystem, bank_card_date, id_client, bank_card_pin) values ('{cardType}','{cardNumber}','{cvvCode}','{currency}','{paymentSystem}','{cardDate}','{DataStorage.idClient}','{cardPin}')";
            SqlCommand commandAddNewCard = new SqlCommand(queryAddNewCard, dataBase.getConnection());
            dataBase.openConnection();
            commandAddNewCard.ExecuteNonQuery();
            dataBase.closeConnection();
            
            MessageBox.Show("Карта успешно создана", "Данные сохранены", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}