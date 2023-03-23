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
    public partial class ChangePhoneNumber : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        public ChangePhoneNumber()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if (!Regex.IsMatch(NumberTextBox.Text, "^[+][7][0-9]{10}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, ico);
                NumberTextBox.Select();
                return;
            }

            var phonenumber = NumberTextBox.Text;
            var changeNumQuery = $"update client set client_phone_number='{phonenumber}' where id_client ='{DataStorage.idClient}'";
            var command = new SqlCommand(changeNumQuery, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() ==1 )
            {
                MessageBox.Show("Номер телефона успешно изменен!");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
            dataBase.closeConnection();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
