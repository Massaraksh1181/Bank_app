
namespace Bank_app.Forms
{
    partial class InternetAndTvPayments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.textBoxPersonalAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxInternetAndTvPayments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_cardNumber = new System.Windows.Forms.Label();
            this.TextBoxCardTo = new System.Windows.Forms.TextBox();
            this.TextBoxCvv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(307, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 43;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 42);
            this.button1.TabIndex = 42;
            this.button1.Text = "Оплатить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 41;
            this.label12.Text = "С карты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Личный счет";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(16, 179);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(209, 20);
            this.textBoxSum.TabIndex = 38;
            // 
            // textBoxPersonalAccount
            // 
            this.textBoxPersonalAccount.Location = new System.Drawing.Point(16, 126);
            this.textBoxPersonalAccount.Name = "textBoxPersonalAccount";
            this.textBoxPersonalAccount.Size = new System.Drawing.Size(209, 20);
            this.textBoxPersonalAccount.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Услуги";
            // 
            // comboBoxInternetAndTvPayments
            // 
            this.comboBoxInternetAndTvPayments.FormattingEnabled = true;
            this.comboBoxInternetAndTvPayments.Location = new System.Drawing.Point(16, 73);
            this.comboBoxInternetAndTvPayments.Name = "comboBoxInternetAndTvPayments";
            this.comboBoxInternetAndTvPayments.Size = new System.Drawing.Size(209, 21);
            this.comboBoxInternetAndTvPayments.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Интернет и ТВ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_cardNumber);
            this.panel1.Controls.Add(this.TextBoxCardTo);
            this.panel1.Controls.Add(this.TextBoxCvv);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(10, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 148);
            this.panel1.TabIndex = 33;
            // 
            // label_cardNumber
            // 
            this.label_cardNumber.AutoSize = true;
            this.label_cardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardNumber.Location = new System.Drawing.Point(17, 39);
            this.label_cardNumber.Name = "label_cardNumber";
            this.label_cardNumber.Size = new System.Drawing.Size(204, 24);
            this.label_cardNumber.TabIndex = 23;
            this.label_cardNumber.Text = "0000 0000 0000 0000";
            // 
            // TextBoxCardTo
            // 
            this.TextBoxCardTo.Location = new System.Drawing.Point(16, 108);
            this.TextBoxCardTo.Name = "TextBoxCardTo";
            this.TextBoxCardTo.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCardTo.TabIndex = 11;
            // 
            // TextBoxCvv
            // 
            this.TextBoxCvv.Location = new System.Drawing.Point(139, 109);
            this.TextBoxCvv.Name = "TextBoxCvv";
            this.TextBoxCvv.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCvv.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Номер карты";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "CVV-код";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Срок действия";
            // 
            // InternetAndTvPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxPersonalAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxInternetAndTvPayments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "InternetAndTvPayments";
            this.Text = "InternetAndYvPayments";
            this.Load += new System.EventHandler(this.InternetAndTvPayments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.TextBox textBoxPersonalAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxInternetAndTvPayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_cardNumber;
        private System.Windows.Forms.TextBox TextBoxCardTo;
        private System.Windows.Forms.TextBox TextBoxCvv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}