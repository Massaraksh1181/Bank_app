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
    public partial class UserForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public UserForm()
        {
            InitializeComponent();
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

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            var queryPIB = $"select concat(client_last_name, ' ', client_first_name, ' ', client_middle_name), client_phone_number, client_email from client where id_client = '{DataStorage.idClient}'";
            SqlCommand commandPIB = new SqlCommand(queryPIB, database.getConnection());
            database.openConnection();
            SqlDataReader reader = commandPIB.ExecuteReader();
            while (reader.Read())
            {
                labelPIB.Text += reader[0].ToString();
                labelPhone.Text += reader[1].ToString();
                labelEmail.Text += reader[2].ToString();
            }
            reader.Close();
        }

        private void ClearFields()
        {
            labelPIB.Text = string.Empty;
            labelPhone.Text = string.Empty;
            labelEmail.Text = string.Empty;
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            RefreshData();
        }

        private void changePhonebutton_Click(object sender, EventArgs e)
        {
            ChangePhoneNumber changePhoneNumber = new ChangePhoneNumber();
            changePhoneNumber.Show();
        }

        private void changeEmailButton_Click(object sender, EventArgs e)
        {
            ChangeEmail changeEmail = new ChangeEmail();
            changeEmail.Show();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();

        }

    }
}
