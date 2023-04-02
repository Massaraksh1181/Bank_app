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
    public partial class RegistrationForm : Form
    {
        DataBaseConnection database = new DataBaseConnection();

        public RegistrationForm()
        {
            InitializeComponent();
            PasswordTextBox.UseSystemPasswordChar = true;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            string caption = "Дата сохранения";

            if(!Regex.IsMatch(LastNameTextBox.Text, "[А-Яа-я]+$"))//проверка через регулярные выражения
            {
                MessageBox.Show("Пожалуйста, введите фамилию повторно!", caption, btn, ico);
                LastNameTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(FirstNameTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Пожалуйста, введите имя повторно!", caption, btn, ico);
                FirstNameTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(MiddleNameTextBox.Text, "[А-Яа-я]+$"))
            {
                MessageBox.Show("Пожалуйста, введите отчество повторно!", caption, btn, ico);
                MiddleNameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(GenderComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("", caption, btn, ico);
                GenderComboBox.Select();
                return;
            }

            if (!Regex.IsMatch(PasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите пароль", caption, btn, ico);
                PasswordTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(ConfirmPasswordTextBox.Text, "^(?=.*?[A-Z])(?=.*[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
            {
                MessageBox.Show("Пожалуйста, введите подтверждение проля", caption, btn, ico);
                ConfirmPasswordTextBox.Select();
                return;
            }

            if(PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Пароль и подтверждение пароля не совпадают", caption, btn, ico);
                ConfirmPasswordTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(EmailTextBox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Пожалуйста, введите вашу почту", caption, btn, ico);
                ConfirmPasswordTextBox.Select();
                return;
            }

            if (!Regex.IsMatch(PhoneNumberTextBox.Text, "^[+][7][0-9]{10}$"))
            {
                MessageBox.Show("Пожалуйста, введите номер телефона", caption, btn, ico);
                PhoneNumberTextBox.Select();
                return;
            }
            string yourSQL = "SELECT client_phone_number FROM client WHERE client_phone_number = '" + PhoneNumberTextBox.Text + "'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand(yourSQL, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой номер телефона уже существует. Невозможно зарагистрировать аккаунт","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Information);
                PhoneNumberTextBox.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Вы хотите сохранить запись?", "Сохранение данных", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO client(client_last_name, client_first_name, client_middle_name, client_gender, client_password,client_email, client_phone_number)";
                mySQL += "VALUES ('"+LastNameTextBox.Text+"','"+FirstNameTextBox.Text + "','" 
                    +MiddleNameTextBox.Text + "','" + GenderComboBox.SelectedItem.ToString() + "','" 
                    +PasswordTextBox.Text + "','" +EmailTextBox.Text + "','" +PhoneNumberTextBox.Text+"')";

                database.openConnection();
                SqlCommand commandAddNewUser = new SqlCommand(mySQL, database.getConnection());//передаем БД строку с запросом выполнения
                commandAddNewUser.ExecuteNonQuery();

                MessageBox.Show("Запись успешно сохранена","Данные сохранены", MessageBoxButtons.OK,MessageBoxIcon.Information);

                clearControls();
                database.closeConnection();// важно закрыть соединение с БД
                Close();
            }
        }

        private void clearControls()
        {
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                comboBox.SelectedItem = null;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Select();
            clearControls();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowPasswordCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                ConfirmPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
                ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}
