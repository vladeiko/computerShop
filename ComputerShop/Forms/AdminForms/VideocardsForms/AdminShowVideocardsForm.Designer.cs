namespace ComputerShop
{
    partial class AdminShowVideocardsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminShowVideocardsForm));
            this.deleteButton = new System.Windows.Forms.Button();
            this.addVideocardButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.showMoreButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.videocardsDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videocardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videocardsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(341, 391);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 29);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addVideocardButton
            // 
            this.addVideocardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVideocardButton.Location = new System.Drawing.Point(241, 391);
            this.addVideocardButton.Name = "addVideocardButton";
            this.addVideocardButton.Size = new System.Drawing.Size(92, 29);
            this.addVideocardButton.TabIndex = 17;
            this.addVideocardButton.Text = "Добавить";
            this.addVideocardButton.UseVisualStyleBackColor = true;
            this.addVideocardButton.Click += new System.EventHandler(this.addVideocardButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.Location = new System.Drawing.Point(440, 391);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(92, 29);
            this.reloadButton.TabIndex = 16;
            this.reloadButton.Text = "Обновить";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // showMoreButton
            // 
            this.showMoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showMoreButton.Location = new System.Drawing.Point(141, 391);
            this.showMoreButton.Name = "showMoreButton";
            this.showMoreButton.Size = new System.Drawing.Size(92, 29);
            this.showMoreButton.TabIndex = 15;
            this.showMoreButton.Text = "Подробнее";
            this.showMoreButton.UseVisualStyleBackColor = true;
            this.showMoreButton.Click += new System.EventHandler(this.showMoreButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(140, 30);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 14;
            this.goBackButton.Text = "НАЗАД";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // videocardsDataGrid
            // 
            this.videocardsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videocardsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.videocardName,
            this.videoMemory});
            this.videocardsDataGrid.Location = new System.Drawing.Point(140, 78);
            this.videocardsDataGrid.Name = "videocardsDataGrid";
            this.videocardsDataGrid.RowHeadersVisible = false;
            this.videocardsDataGrid.Size = new System.Drawing.Size(574, 300);
            this.videocardsDataGrid.TabIndex = 13;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // videocardName
            // 
            this.videocardName.FillWeight = 400F;
            this.videocardName.HeaderText = "Название";
            this.videocardName.Name = "videocardName";
            this.videocardName.ReadOnly = true;
            this.videocardName.Width = 400;
            // 
            // videoMemory
            // 
            this.videoMemory.FillWeight = 160F;
            this.videoMemory.HeaderText = "Видеопамять";
            this.videoMemory.Name = "videoMemory";
            this.videoMemory.ReadOnly = true;
            this.videoMemory.Width = 160;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // AdminShowVideocardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addVideocardButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.showMoreButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.videocardsDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminShowVideocardsForm";
            this.Text = "\"Premium PC\". Администратор. Просмотр видеокарт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminShowVideocardsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.videocardsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addVideocardButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button showMoreButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridView videocardsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn videocardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoMemory;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}