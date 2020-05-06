namespace ComputerShop
{
    partial class AdminShowComputersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminShowComputersForm));
            this.goBackButton = new System.Windows.Forms.Button();
            this.computersDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videocardName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAMname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 9;
            this.goBackButton.Text = "НАЗАД";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // computersDataGrid
            // 
            this.computersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.manufacturer,
            this.model,
            this.procName,
            this.videocardName,
            this.RAMname,
            this.price});
            this.computersDataGrid.Location = new System.Drawing.Point(12, 106);
            this.computersDataGrid.Name = "computersDataGrid";
            this.computersDataGrid.RowHeadersVisible = false;
            this.computersDataGrid.Size = new System.Drawing.Size(830, 300);
            this.computersDataGrid.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Производитель";
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            // 
            // model
            // 
            this.model.HeaderText = "Модель";
            this.model.Name = "model";
            this.model.ReadOnly = true;
            // 
            // procName
            // 
            this.procName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.procName.FillWeight = 140F;
            this.procName.HeaderText = "Процессор";
            this.procName.Name = "procName";
            this.procName.ReadOnly = true;
            // 
            // videocardName
            // 
            this.videocardName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.videocardName.FillWeight = 170F;
            this.videocardName.HeaderText = "Видеокарта";
            this.videocardName.Name = "videocardName";
            this.videocardName.ReadOnly = true;
            // 
            // RAMname
            // 
            this.RAMname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RAMname.FillWeight = 140F;
            this.RAMname.HeaderText = "ОЗУ";
            this.RAMname.Name = "RAMname";
            this.RAMname.ReadOnly = true;
            // 
            // price
            // 
            this.price.FillWeight = 50F;
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // AdminShowComputersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.computersDataGrid);
            this.Controls.Add(this.goBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminShowComputersForm";
            this.Text = "\"Premium PC\". Администратор. Просмотр компьютеров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminShowComputersForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridView computersDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn procName;
        private System.Windows.Forms.DataGridViewTextBoxColumn videocardName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAMname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}