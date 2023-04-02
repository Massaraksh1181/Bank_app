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

    public partial class ChangePassword : Form
    {
        DataBaseConnection dataBase = new DataBaseConnection();

        public ChangePassword()
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

            if (!Regex.IsMatch(passwordTextBox.Text, "^(?=.*?[A-Z])(?=.*[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите пароль", caption, btn, ico);
                passwordTextBox.Select();
                return;
            }

            var pass = passwordTextBox.Text;
            var changeNumQuery = $"update client set client_password ='{pass}' where id_client ='{DataStorage.idClient}'";
            var command = new SqlCommand(changeNumQuery, dataBase.getConnection());
            dataBase.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пароль успешно изменен!");
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
