
namespace Bank_app.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.addCard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_cardNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelcardTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_cardCvv = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.pictureBoxVisa = new System.Windows.Forms.PictureBox();
            this.pictureBoxMastercard = new System.Windows.Forms.PictureBox();
            this.cardsComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMastercard)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 43);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(9, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 31);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(740, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // addCard
            // 
            this.addCard.Location = new System.Drawing.Point(441, 106);
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(75, 23);
            this.addCard.TabIndex = 2;
            this.addCard.Text = "Добавить";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Карты:";
            // 
            // refreshPictureBox
            // 
            this.refreshPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("refreshPictureBox.Image")));
            this.refreshPictureBox.Location = new System.Drawing.Point(730, 61);
            this.refreshPictureBox.Name = "refreshPictureBox";
            this.refreshPictureBox.Size = new System.Drawing.Size(48, 44);
            this.refreshPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refreshPictureBox.TabIndex = 4;
            this.refreshPictureBox.TabStop = false;
            this.refreshPictureBox.Click += new System.EventHandler(this.refreshPictureBox_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(110, 374);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 88);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Перевод на карту";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(457, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 88);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(110, 468);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 72);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(457, 468);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 72);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(110, 546);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 67);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(457, 546);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 67);
            this.panel7.TabIndex = 10;
            // 
            // label_cardNumber
            // 
            this.label_cardNumber.AutoSize = true;
            this.label_cardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardNumber.Location = new System.Drawing.Point(123, 167);
            this.label_cardNumber.Name = "label_cardNumber";
            this.label_cardNumber.Size = new System.Drawing.Size(204, 24);
            this.label_cardNumber.TabIndex = 11;
            this.label_cardNumber.Text = "0000 0000 0000 0000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(124, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Действительна до";
            // 
            // labelcardTo
            // 
            this.labelcardTo.AutoSize = true;
            this.labelcardTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcardTo.Location = new System.Drawing.Point(251, 256);
            this.labelcardTo.Name = "labelcardTo";
            this.labelcardTo.Size = new System.Drawing.Size(59, 20);
            this.labelcardTo.TabIndex = 13;
            this.labelcardTo.Text = "число";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(361, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "CVV";
            // 
            // label_cardCvv
            // 
            this.label_cardCvv.AutoSize = true;
            this.label_cardCvv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cardCvv.Location = new System.Drawing.Point(415, 256);
            this.label_cardCvv.Name = "label_cardCvv";
            this.label_cardCvv.Size = new System.Drawing.Size(26, 16);
            this.label_cardCvv.TabIndex = 15;
            this.label_cardCvv.Text = "***";
            this.label_cardCvv.Click += new System.EventHandler(this.label_cardCvv_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceLabel.Location = new System.Drawing.Point(194, 311);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(61, 16);
            this.balanceLabel.TabIndex = 17;
            this.balanceLabel.Text = "баланс";
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currencyLabel.Location = new System.Drawing.Point(126, 311);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(63, 16);
            this.currencyLabel.TabIndex = 18;
            this.currencyLabel.Text = "валюта";
            // 
            // pictureBoxVisa
            // 
            this.pictureBoxVisa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVisa.Image")));
            this.pictureBoxVisa.Location = new System.Drawing.Point(364, 167);
            this.pictureBoxVisa.Name = "pictureBoxVisa";
            this.pictureBoxVisa.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisa.TabIndex = 19;
            this.pictureBoxVisa.TabStop = false;
            // 
            // pictureBoxMastercard
            // 
            this.pictureBoxMastercard.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMastercard.Image")));
            this.pictureBoxMastercard.Location = new System.Drawing.Point(470, 167);
            this.pictureBoxMastercard.Name = "pictureBoxMastercard";
            this.pictureBoxMastercard.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxMastercard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMastercard.TabIndex = 20;
            this.pictureBoxMastercard.TabStop = false;
            // 
            // cardsComboBox
            // 
            this.cardsComboBox.FormattingEnabled = true;
            this.cardsComboBox.Location = new System.Drawing.Point(303, 108);
            this.cardsComboBox.Name = "cardsComboBox";
            this.cardsComboBox.Size = new System.Drawing.Size(121, 21);
            this.cardsComboBox.TabIndex = 1;
            this.cardsComboBox.SelectedIndexChanged += new System.EventHandler(this.cardsComboBox_OnSelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.cardsComboBox);
            this.Controls.Add(this.pictureBoxMastercard);
            this.Controls.Add(this.pictureBoxVisa);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label_cardCvv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelcardTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_cardNumber);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.refreshPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMastercard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button addCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox refreshPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_cardNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelcardTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_cardCvv;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.PictureBox pictureBoxVisa;
        private System.Windows.Forms.PictureBox pictureBoxMastercard;
        private System.Windows.Forms.ComboBox cardsComboBox;
    }
}