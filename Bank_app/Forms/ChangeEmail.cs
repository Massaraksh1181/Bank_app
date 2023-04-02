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
    public partial class ChangeEmail : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        public ChangeEmail()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Дата сохранения";

            if (!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста, введите вашу почту", caption, btn, ico);
                EmailTextBox.Select();
                return;
            }

            var email = EmailTextBox.Text;
            var changeNumQuery = $"update client set client_email ='{email}' where id_client ='{DataStorage.idClient}'";
            var command = new SqlCommand(changeNumQuery, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Электронная почта успешно изменена!");
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
