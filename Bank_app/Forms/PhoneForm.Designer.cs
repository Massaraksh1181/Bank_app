
namespace Bank_app.Forms
{
    partial class PhoneForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCommission = new System.Windows.Forms.Label();
            this.labelTotalSum = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_cardNumber = new System.Windows.Forms.Label();
            this.TextBoxCardTo = new System.Windows.Forms.TextBox();
            this.TextBoxCvv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пополнение мобильного";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(303, 22);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "+7";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(45, 81);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(132, 20);
            this.textBoxNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер";
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(27, 127);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(150, 21);
            this.comboBoxOperator.TabIndex = 10;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(26, 188);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(151, 20);
            this.textBoxSum.TabIndex = 12;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Комиссия ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "К оплате";
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Location = new System.Drawing.Point(164, 229);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(13, 13);
            this.labelCommission.TabIndex = 15;
            this.labelCommission.Text = "0";
            // 
            // labelTotalSum
            // 
            this.labelTotalSum.AutoSize = true;
            this.labelTotalSum.Location = new System.Drawing.Point(164, 256);
            this.labelTotalSum.Name = "labelTotalSum";
            this.labelTotalSum.Size = new System.Drawing.Size(13, 13);
            this.labelTotalSum.TabIndex = 16;
            this.labelTotalSum.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RUB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "RUB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(188, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "RUB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(22, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "С карты";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label_cardNumber);
            this.panel1.Controls.Add(this.TextBoxCardTo);
            this.panel1.Controls.Add(this.TextBoxCvv);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Location = new System.Drawing.Point(12, 333);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 148);
            this.panel1.TabIndex = 21;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "Пополнить счет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 552);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalSum);
            this.Controls.Add(this.labelCommission);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhoneForm";
            this.Text = "PhoneForm";
            this.Load += new System.EventHandler(this.PhoneForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.Label labelTotalSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxCardTo;
        private System.Windows.Forms.TextBox TextBoxCvv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_cardNumber;
    }
}