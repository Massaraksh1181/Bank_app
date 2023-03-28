using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_app.Classes;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bank_app.Forms
{
    public partial class MainForm : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void addCard_Click(object sender, EventArgs e)
        {
            AddBankCard addBankCard = new AddBankCard();
            addBankCard.ShowDialog();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            label_cardNumber.BringToFront();
            label_cardNumber.Text = "";
            labelcardTo.BringToFront();
            label6.BringToFront();
            label_cardCvv.BringToFront();
            pictureBoxMastercard.Visible = false;
            pictureBoxVisa.Visible = false;

            var queryMyCards = $"SELECT id_bank_card, bank_card_number from bank_card where id_client =' {DataStorage.idClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, dataBase.getConnection());
            dataBase.openConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            cardsComboBox.DataSource = cards;
            cardsComboBox.ValueMember = "id_bank_card";
            cardsComboBox.DisplayMember = "bank_card_number";
            dataBase.closeConnection();
            
            selectCard();  
        }

        private void selectCard()
        {
            label_cardNumber.Text = "";
            string paymentSystem = "";
            string querySelectCard = $"select bank_card_number, bank_card_cvv_code," +
                $" CONCAT(FORMAT(bank_card_date, '%M'), '/', FORMAT (bank_card_date,'%y'))," +
                $" bank_card_paymentSystem, bank_card_balance," +
                $" bank_card_currency from bank_card where bank_card_number = " +
                $"'{cardsComboBox.GetItemText(cardsComboBox.SelectedItem)}'";
            SqlCommand command = new SqlCommand(querySelectCard, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var cardNumber = reader[0].ToString();
                int tmp = 0;
                int tmp1 = 4;
                for (int m = 0; m < 4; m++)
                {
                    for (int n = tmp; n < tmp1; n++)
                    {
                        label_cardNumber.Text += cardNumber[n].ToString();
                    }
                    label_cardNumber.Text += " ";
                    tmp += 4;
                    tmp1 += 4;
                }
                label_cardCvv.Text = reader[1].ToString();
                labelcardTo.Text = reader[2].ToString();
                paymentSystem = reader[3].ToString();
                balanceLabel.Text = Math.Round(Convert.ToDouble(reader[4]), 2).ToString();
                currencyLabel.Text = reader[5].ToString();
                DataStorage.cardCVV = label_cardCvv.Text;
                label_cardCvv.Text = "***";
            }
            reader.Close();

            if (paymentSystem == "Visa")
            {
                pictureBoxVisa.Visible = true;
                pictureBoxMastercard.Visible = false;
            }
            else
            {
                pictureBoxMastercard.Visible = true;
                pictureBoxVisa.Visible = false;
            }
            //dataBase.closeConnection();//////////////
        }

        private void label_cardCvv_Click(object sender, EventArgs e)
        {
            if (label_cardCvv.Text == "***")
            {
                label_cardCvv.Text = DataStorage.cardCVV;
            }
            else
                label_cardCvv.Text = "***";
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            var queryMyCards = $"SELECT id_bank_card, bank_card_number from bank_card where id_client =' {DataStorage.idClient}'";
            SqlDataAdapter commandMyCards = new SqlDataAdapter(queryMyCards, dataBase.getConnection());
            dataBase.openConnection();
            DataTable cards = new DataTable();
            commandMyCards.Fill(cards);
            cardsComboBox.DataSource = cards;
            cardsComboBox.ValueMember = "id_bank_card";
            cardsComboBox.DisplayMember = "bank_card_number";
            dataBase.closeConnection();

            selectCard();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectCard();
        }

        private void cardsComboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectCard();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            SendToForm sendToForm = new SendToForm();
            DataStorage.bankCard = CardTextBox.Text;
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            cardsComboBox.Text = "";
            sendToForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserForm userform = new UserForm();
            userform.ShowDialog();
        }

        private void pictureBoxHistory_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PhoneForm phoneForm = new PhoneForm();
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            DataStorage.phoneNumber = textBox1.Text;
            textBox1.Text = "";
            phoneForm.Show();
        }

        private void buttonCommunal_Click(object sender, EventArgs e)
        {
            CommunalPayments communalPayments = new CommunalPayments();
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            communalPayments.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InternetAndTvPayments internetAndTvPayments = new InternetAndTvPayments();
            DataStorage.cardNumber = cardsComboBox.GetItemText(cardsComboBox.SelectedItem);
            internetAndTvPayments.Show();
        }
    }
}