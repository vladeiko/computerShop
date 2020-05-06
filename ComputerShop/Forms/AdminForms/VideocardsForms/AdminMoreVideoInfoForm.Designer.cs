﻿namespace ComputerShop
{
    partial class AdminMoreVideoInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMoreVideoInfoForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.videoNameTextBox = new System.Windows.Forms.TextBox();
            this.declineButton = new System.Windows.Forms.Button();
            this.acceptButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.videomemoryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название:";
            // 
            // videoNameTextBox
            // 
            this.videoNameTextBox.Location = new System.Drawing.Point(148, 231);
            this.videoNameTextBox.Name = "videoNameTextBox";
            this.videoNameTextBox.ReadOnly = true;
            this.videoNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.videoNameTextBox.TabIndex = 28;
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(214, 393);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(30, 30);
            this.declineButton.TabIndex = 27;
            this.declineButton.Text = "❌";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Visible = false;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(158, 393);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(30, 30);
            this.acceptButton.TabIndex = 26;
            this.acceptButton.Text = "✔";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Visible = false;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(148, 386);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(106, 30);
            this.editButton.TabIndex = 25;
            this.editButton.Text = "Изменить";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Видеопамять:";
            // 
            // videomemoryTextBox
            // 
            this.videomemoryTextBox.Location = new System.Drawing.Point(148, 281);
            this.videomemoryTextBox.Name = "videomemoryTextBox";
            this.videomemoryTextBox.ReadOnly = true;
            this.videomemoryTextBox.Size = new System.Drawing.Size(100, 20);
            this.videomemoryTextBox.TabIndex = 41;
            // 
            // AdminMoreVideoInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videomemoryTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoNameTextBox);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.editButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMoreVideoInfoForm";
            this.Text = "\"Premium PC\". Администратор. Информация о видеокарте";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox videoNameTextBox;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox videomemoryTextBox;
    }
}