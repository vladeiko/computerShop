namespace ComputerShop
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.bSignIn = new System.Windows.Forms.Button();
            this.bSignUp = new System.Windows.Forms.Button();
            this.shopName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSignIn
            // 
            this.bSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSignIn.Location = new System.Drawing.Point(65, 18);
            this.bSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.bSignIn.Name = "bSignIn";
            this.bSignIn.Size = new System.Drawing.Size(65, 30);
            this.bSignIn.TabIndex = 0;
            this.bSignIn.Text = "ВОЙТИ";
            this.bSignIn.UseVisualStyleBackColor = true;
            this.bSignIn.Click += new System.EventHandler(this.bSignIn_Click);
            // 
            // bSignUp
            // 
            this.bSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSignUp.Location = new System.Drawing.Point(47, 68);
            this.bSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.bSignUp.Name = "bSignUp";
            this.bSignUp.Size = new System.Drawing.Size(100, 30);
            this.bSignUp.TabIndex = 1;
            this.bSignUp.Text = "Регистрация";
            this.bSignUp.UseVisualStyleBackColor = true;
            this.bSignUp.Click += new System.EventHandler(this.bSignUp_Click);
            // 
            // shopName
            // 
            this.shopName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopName.AutoSize = true;
            this.shopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shopName.Location = new System.Drawing.Point(151, 191);
            this.shopName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shopName.Name = "shopName";
            this.shopName.Size = new System.Drawing.Size(219, 34);
            this.shopName.TabIndex = 2;
            this.shopName.Text = "Магазин компьютерной техники\r\n\"Premium PC\"";
            this.shopName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bSignIn);
            this.groupBox1.Controls.Add(this.bSignUp);
            this.groupBox1.Location = new System.Drawing.Point(164, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shopName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.Text = "\"Premium PC\". Приветствие";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSignIn;
        private System.Windows.Forms.Button bSignUp;
        private System.Windows.Forms.Label shopName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

