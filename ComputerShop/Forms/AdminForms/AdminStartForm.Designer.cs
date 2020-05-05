namespace ComputerShop
{
    partial class AdminStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStartForm));
            this.showUsersButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.showComputersButton = new System.Windows.Forms.Button();
            this.showProcessorsButton = new System.Windows.Forms.Button();
            this.showVideocardsButton = new System.Windows.Forms.Button();
            this.showRAMsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showUsersButton
            // 
            this.showUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showUsersButton.Location = new System.Drawing.Point(275, 40);
            this.showUsersButton.Name = "showUsersButton";
            this.showUsersButton.Size = new System.Drawing.Size(148, 63);
            this.showUsersButton.TabIndex = 0;
            this.showUsersButton.Text = "ПОСМОТРЕТЬ ПОЛЬЗОВАТЕЛЕЙ";
            this.showUsersButton.UseVisualStyleBackColor = true;
            this.showUsersButton.Click += new System.EventHandler(this.showUsersButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(311, 450);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 27);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "НАЗАД";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // showComputersButton
            // 
            this.showComputersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showComputersButton.Location = new System.Drawing.Point(275, 117);
            this.showComputersButton.Name = "showComputersButton";
            this.showComputersButton.Size = new System.Drawing.Size(148, 63);
            this.showComputersButton.TabIndex = 2;
            this.showComputersButton.Text = "ПОСМОТРЕТЬ КОМПЬЮТЕРЫ";
            this.showComputersButton.UseVisualStyleBackColor = true;
            // 
            // showProcessorsButton
            // 
            this.showProcessorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showProcessorsButton.Location = new System.Drawing.Point(275, 195);
            this.showProcessorsButton.Name = "showProcessorsButton";
            this.showProcessorsButton.Size = new System.Drawing.Size(148, 63);
            this.showProcessorsButton.TabIndex = 3;
            this.showProcessorsButton.Text = "ПОСМОТРЕТЬ ПРОЦЕССОРЫ";
            this.showProcessorsButton.UseVisualStyleBackColor = true;
            this.showProcessorsButton.Click += new System.EventHandler(this.showProcessorsButton_Click);
            // 
            // showVideocardsButton
            // 
            this.showVideocardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showVideocardsButton.Location = new System.Drawing.Point(275, 274);
            this.showVideocardsButton.Name = "showVideocardsButton";
            this.showVideocardsButton.Size = new System.Drawing.Size(148, 63);
            this.showVideocardsButton.TabIndex = 4;
            this.showVideocardsButton.Text = "ПОСМОТРЕТЬ ВИДЕОКАРТЫ";
            this.showVideocardsButton.UseVisualStyleBackColor = true;
            // 
            // showRAMsButton
            // 
            this.showRAMsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showRAMsButton.Location = new System.Drawing.Point(275, 352);
            this.showRAMsButton.Name = "showRAMsButton";
            this.showRAMsButton.Size = new System.Drawing.Size(148, 63);
            this.showRAMsButton.TabIndex = 5;
            this.showRAMsButton.Text = "ПОСМОТРЕТЬ\r\nОЗУ";
            this.showRAMsButton.UseVisualStyleBackColor = true;
            // 
            // AdminStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 500);
            this.Controls.Add(this.showRAMsButton);
            this.Controls.Add(this.showVideocardsButton);
            this.Controls.Add(this.showProcessorsButton);
            this.Controls.Add(this.showComputersButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.showUsersButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminStartForm";
            this.Text = "\"Premium PC\". Администратор. Начало";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminStartForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showUsersButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button showComputersButton;
        private System.Windows.Forms.Button showProcessorsButton;
        private System.Windows.Forms.Button showVideocardsButton;
        private System.Windows.Forms.Button showRAMsButton;
    }
}