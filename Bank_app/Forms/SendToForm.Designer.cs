
namespace Bank_app.Forms
{
    partial class SendToForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxCardTo = new System.Windows.Forms.TextBox();
            this.TextBoxCvv = new System.Windows.Forms.TextBox();
            this.TextBoxCard = new System.Windows.Forms.TextBox();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBoxCardDestination = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(304, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "С карты";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер карты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Срок действия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CVV-код";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Карта получателя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сумма";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.TextBoxCardTo);
            this.panel1.Controls.Add(this.TextBoxCvv);
            this.panel1.Controls.Add(this.TextBoxCard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(25, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 148);
            this.panel1.TabIndex = 11;
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
            // TextBoxCard
            // 
            this.TextBoxCard.Location = new System.Drawing.Point(16, 39);
            this.TextBoxCard.Name = "TextBoxCard";
            this.TextBoxCard.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCard.TabIndex = 9;
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Location = new System.Drawing.Point(25, 380);
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.Size = new System.Drawing.Size(293, 20);
            this.TextBoxSum.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.TextBoxCardDestination);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(25, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 65);
            this.panel2.TabIndex = 12;
            // 
            // TextBoxCardDestination
            // 
            this.TextBoxCardDestination.Location = new System.Drawing.Point(16, 33);
            this.TextBoxCardDestination.Name = "TextBoxCardDestination";
            this.TextBoxCardDestination.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCardDestination.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Номер карты";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(25, 424);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(293, 54);
            this.SendBtn.TabIndex = 13;
            this.SendBtn.Text = "Провести";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SendToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 506);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendToForm";
            this.Text = "SendToForm";
            this.Load += new System.EventHandler(this.SendToForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox TextBoxCard;
        private System.Windows.Forms.TextBox TextBoxCardDestination;
        private System.Windows.Forms.TextBox TextBoxCvv;
        private System.Windows.Forms.TextBox TextBoxCardTo;
    }
}