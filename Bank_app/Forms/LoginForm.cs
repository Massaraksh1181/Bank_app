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
    public partial class LoginForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
        }


        /* public const int WM_NCLBUTTONDOWN = 0xA1;
         public const int HT_CAPTION = 0x2;

         [System.Runtime.InteropServices.DllImport("user32.dll")]

         public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

         [System.Runtime.InteropServices.DllImport("user32.dll")]

         public static extern bool ReleaseCapture();

         private void LoginForm_MouseDown(object sender, MouseEventArgs e)
         {
             if (e.Button == MouseButtons.Left)
             {
                 ReleaseCapture();
                 SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
             }
         }*/

        protected override void WndProc(ref Message message)// претаскивание окна из любого места
        {
            if (message.Msg == 0x201)
            {
                base.Capture = false;
                message = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            }
            base.WndProc(ref message);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PhoneNumberTextBox.Select();//при открытии формы номер телефона будет выбран автоматически
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PhoneNumberTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text))//только если поля заполнены
            {
                var querySelectClient = $"SELECT * FROM client WHERE client_phone_number = '{PhoneNumberTextBox.Text}' AND client_password = '{PasswordTextBox.Text}'";
                var queryGetId = $"SELECT id_client FROM client WHERE client_phone_number = '{PhoneNumberTextBox.Text}'";
                var commandGetId = new SqlCommand(queryGetId, database.getConnection());

                database.openConnection();
                SqlDataReader reader = commandGetId.ExecuteReader();
                while (reader.Read())
                {
                    DataStorage.idClient = reader[0].ToString();
                }
                reader.Close();

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand(querySelectClient, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);// сносим значение, смотрим существует ли такой аккаунт

                if (table.Rows.Count != 0)//если строк не 0, значит такой пользователь есть
                {
                    PhoneNumberTextBox.Clear();
                    PasswordTextBox.Clear();
                    ShowPasswordCheckBox.Checked = false;

                    Hide();

                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                    mainForm = null;

                    Show();
                }
                else //если строк 0, пользователя нет
                {
                    MessageBox.Show("Имя пользователя или пароль не верны, попробуйте ввести еще раз","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    PhoneNumberTextBox.Focus();
                    PhoneNumberTextBox.SelectAll();
                }
            }
            else 
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                PhoneNumberTextBox.Select();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

}
