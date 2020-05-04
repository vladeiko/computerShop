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
            this.SuspendLayout();
            // 
            // showUsersButton
            // 
            this.showUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showUsersButton.Location = new System.Drawing.Point(212, 39);
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
            this.goBackButton.Location = new System.Drawing.Point(246, 352);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 27);
            this.goBackButton.TabIndex = 1;
            this.goBackButton.Text = "НАЗАД";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // AdminStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.showUsersButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminStartForm";
            this.Text = "\"Название\". Администратор. Начало";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminStartForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showUsersButton;
        private System.Windows.Forms.Button goBackButton;
    }
}