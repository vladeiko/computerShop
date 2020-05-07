namespace ComputerShop
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bSignUp = new System.Windows.Forms.Button();
            this.acceptCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.addPictureButton = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.secnameErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.phoneErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.LoginTextBox.Location = new System.Drawing.Point(97, 100);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(226, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(97, 135);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(97, 171);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(226, 20);
            this.SecondNameTextBox.TabIndex = 2;
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.Location = new System.Drawing.Point(97, 209);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.Size = new System.Drawing.Size(226, 20);
            this.PassWordTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // bSignUp
            // 
            this.bSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSignUp.Location = new System.Drawing.Point(144, 356);
            this.bSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(100, 30);
            this.bSignUp.TabIndex = 8;
            this.bSignUp.Text = "Регистрация";
            this.bSignUp.UseVisualStyleBackColor = true;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            // 
            // acceptCheckBox
            // 
            this.acceptCheckBox.AutoSize = true;
            this.acceptCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acceptCheckBox.Location = new System.Drawing.Point(97, 320);
            this.acceptCheckBox.Name = "acceptCheckBox";
            this.acceptCheckBox.Size = new System.Drawing.Size(226, 20);
            this.acceptCheckBox.TabIndex = 9;
            this.acceptCheckBox.Text = "Со всеми правилами согласен";
            this.acceptCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(97, 249);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(226, 20);
            this.EmailTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Телефон";
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 14;
            this.goBackButton.Text = "НАЗАД";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(428, 70);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(235, 235);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPictureBox.TabIndex = 15;
            this.avatarPictureBox.TabStop = false;
            // 
            // addPictureButton
            // 
            this.addPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPictureButton.Location = new System.Drawing.Point(497, 329);
            this.addPictureButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPictureButton.Name = "addPictureButton";
            this.addPictureButton.Size = new System.Drawing.Size(104, 49);
            this.addPictureButton.TabIndex = 16;
            this.addPictureButton.Text = "Выбрать\r\nизображение";
            this.addPictureButton.UseVisualStyleBackColor = true;
            this.addPictureButton.Click += new System.EventHandler(this.addPictureButton_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(97, 285);
            this.PhoneTextBox.Mask = "8-(999)-000-00-00";
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(226, 20);
            this.PhoneTextBox.TabIndex = 17;
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(329, 103);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.loginErrorLabel.TabIndex = 18;
            this.loginErrorLabel.Text = "Ошибка ввода";
            this.loginErrorLabel.Visible = false;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(329, 139);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.nameErrorLabel.TabIndex = 19;
            this.nameErrorLabel.Text = "Ошибка ввода";
            this.nameErrorLabel.Visible = false;
            // 
            // secnameErrorLabel
            // 
            this.secnameErrorLabel.AutoSize = true;
            this.secnameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.secnameErrorLabel.Location = new System.Drawing.Point(329, 174);
            this.secnameErrorLabel.Name = "secnameErrorLabel";
            this.secnameErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.secnameErrorLabel.TabIndex = 20;
            this.secnameErrorLabel.Text = "Ошибка ввода";
            this.secnameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(329, 212);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.passwordErrorLabel.TabIndex = 21;
            this.passwordErrorLabel.Text = "Ошибка ввода";
            this.passwordErrorLabel.Visible = false;
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.emailErrorLabel.Location = new System.Drawing.Point(329, 252);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.emailErrorLabel.TabIndex = 22;
            this.emailErrorLabel.Text = "Ошибка ввода";
            this.emailErrorLabel.Visible = false;
            // 
            // phoneErrorLabel
            // 
            this.phoneErrorLabel.AutoSize = true;
            this.phoneErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneErrorLabel.Location = new System.Drawing.Point(329, 289);
            this.phoneErrorLabel.Name = "phoneErrorLabel";
            this.phoneErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.phoneErrorLabel.TabIndex = 23;
            this.phoneErrorLabel.Text = "Ошибка ввода";
            this.phoneErrorLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 421);
            this.Controls.Add(this.phoneErrorLabel);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.secnameErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.addPictureButton);
            this.Controls.Add(this.avatarPictureBox);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.acceptCheckBox);
            this.Controls.Add(this.bSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.Text = "\"Premium PC\". Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSignUp;
        private System.Windows.Forms.CheckBox acceptCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Button addPictureButton;
        private System.Windows.Forms.MaskedTextBox PhoneTextBox;
        private System.Windows.Forms.Label loginErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label secnameErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label emailErrorLabel;
        private System.Windows.Forms.Label phoneErrorLabel;
    }
}