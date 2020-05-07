namespace ComputerShop
{
    partial class AdminMoreComputerInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMoreComputerInfoForm));
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ramComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.videocardComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processorComboBox = new System.Windows.Forms.ComboBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.addPictureButton = new System.Windows.Forms.Button();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.mhzTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numOfCoresTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.videomemoryTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ramSizeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.printImageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // priceUpDown
            // 
            this.priceUpDown.DecimalPlaces = 2;
            this.priceUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceUpDown.Location = new System.Drawing.Point(443, 296);
            this.priceUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.priceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.ReadOnly = true;
            this.priceUpDown.Size = new System.Drawing.Size(120, 20);
            this.priceUpDown.TabIndex = 61;
            this.priceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(393, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(398, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "ОЗУ:";
            // 
            // ramComboBox
            // 
            this.ramComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ramComboBox.Enabled = false;
            this.ramComboBox.FormattingEnabled = true;
            this.ramComboBox.Location = new System.Drawing.Point(443, 231);
            this.ramComboBox.Name = "ramComboBox";
            this.ramComboBox.Size = new System.Drawing.Size(325, 21);
            this.ramComboBox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(347, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 57;
            this.label4.Text = "Видеокарта:";
            // 
            // videocardComboBox
            // 
            this.videocardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videocardComboBox.Enabled = false;
            this.videocardComboBox.FormattingEnabled = true;
            this.videocardComboBox.Location = new System.Drawing.Point(443, 168);
            this.videocardComboBox.Name = "videocardComboBox";
            this.videocardComboBox.Size = new System.Drawing.Size(325, 21);
            this.videocardComboBox.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(354, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Процессор:";
            // 
            // processorComboBox
            // 
            this.processorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processorComboBox.Enabled = false;
            this.processorComboBox.Location = new System.Drawing.Point(443, 74);
            this.processorComboBox.Name = "processorComboBox";
            this.processorComboBox.Size = new System.Drawing.Size(325, 21);
            this.processorComboBox.TabIndex = 53;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(443, 43);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.ReadOnly = true;
            this.modelTextBox.Size = new System.Drawing.Size(325, 20);
            this.modelTextBox.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(322, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Производитель:";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(443, 12);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.ReadOnly = true;
            this.manufacturerTextBox.Size = new System.Drawing.Size(325, 20);
            this.manufacturerTextBox.TabIndex = 49;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(376, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Модель:";
            // 
            // addPictureButton
            // 
            this.addPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPictureButton.Location = new System.Drawing.Point(32, 328);
            this.addPictureButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPictureButton.Name = "addPictureButton";
            this.addPictureButton.Size = new System.Drawing.Size(104, 49);
            this.addPictureButton.TabIndex = 48;
            this.addPictureButton.Text = "Выбрать\r\nизображение";
            this.addPictureButton.UseVisualStyleBackColor = true;
            this.addPictureButton.Visible = false;
            this.addPictureButton.Click += new System.EventHandler(this.addPictureButton_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(300, 300);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 47;
            this.imagePictureBox.TabStop = false;
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(597, 354);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(30, 30);
            this.declineButton.TabIndex = 64;
            this.declineButton.Text = "❌";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Visible = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(541, 354);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(30, 30);
            this.acceptButton.TabIndex = 63;
            this.acceptButton.Text = "✔";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(531, 347);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 30);
            this.editButton.TabIndex = 62;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // mhzTextBox
            // 
            this.mhzTextBox.Location = new System.Drawing.Point(541, 137);
            this.mhzTextBox.Name = "mhzTextBox";
            this.mhzTextBox.ReadOnly = true;
            this.mhzTextBox.Size = new System.Drawing.Size(184, 20);
            this.mhzTextBox.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(495, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 88;
            this.label8.Text = "MHZ:";
            // 
            // numOfCoresTextBox
            // 
            this.numOfCoresTextBox.Location = new System.Drawing.Point(541, 106);
            this.numOfCoresTextBox.Name = "numOfCoresTextBox";
            this.numOfCoresTextBox.ReadOnly = true;
            this.numOfCoresTextBox.Size = new System.Drawing.Size(184, 20);
            this.numOfCoresTextBox.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(447, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 86;
            this.label7.Text = "Кол-во ядер:";
            // 
            // videomemoryTextBox
            // 
            this.videomemoryTextBox.Location = new System.Drawing.Point(541, 200);
            this.videomemoryTextBox.Name = "videomemoryTextBox";
            this.videomemoryTextBox.ReadOnly = true;
            this.videomemoryTextBox.Size = new System.Drawing.Size(184, 20);
            this.videomemoryTextBox.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(437, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 90;
            this.label9.Text = "Видеопамять:";
            // 
            // ramSizeTextBox
            // 
            this.ramSizeTextBox.Location = new System.Drawing.Point(541, 263);
            this.ramSizeTextBox.Name = "ramSizeTextBox";
            this.ramSizeTextBox.ReadOnly = true;
            this.ramSizeTextBox.Size = new System.Drawing.Size(184, 20);
            this.ramSizeTextBox.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(447, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 92;
            this.label10.Text = "Размер (ГБ):";
            // 
            // printImageButton
            // 
            this.printImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printImageButton.Location = new System.Drawing.Point(156, 337);
            this.printImageButton.Name = "printImageButton";
            this.printImageButton.Size = new System.Drawing.Size(106, 30);
            this.printImageButton.TabIndex = 94;
            this.printImageButton.Text = "Печать";
            this.printImageButton.UseVisualStyleBackColor = true;
            this.printImageButton.Click += new System.EventHandler(this.printImageButton_Click);
            // 
            // AdminMoreComputerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printImageButton);
            this.Controls.Add(this.ramSizeTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.videomemoryTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mhzTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numOfCoresTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.priceUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ramComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.videocardComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.processorComboBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addPictureButton);
            this.Controls.Add(this.imagePictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMoreComputerInfoForm";
            this.Text = "\"Premium PC\". Администратор. Информация о компьютере";
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown priceUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ramComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox videocardComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox processorComboBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPictureButton;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox mhzTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numOfCoresTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox videomemoryTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ramSizeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button printImageButton;
    }
}