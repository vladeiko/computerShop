namespace ComputerShop
{
    partial class AdminShowCPUsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminShowCPUsForm));
            this.deleteButton = new System.Windows.Forms.Button();
            this.addProcessorButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.showMoreButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.processorsDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfCores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClockFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.processorsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(341, 391);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 29);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addProcessorButton
            // 
            this.addProcessorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProcessorButton.Location = new System.Drawing.Point(241, 391);
            this.addProcessorButton.Name = "addProcessorButton";
            this.addProcessorButton.Size = new System.Drawing.Size(92, 29);
            this.addProcessorButton.TabIndex = 11;
            this.addProcessorButton.Text = "Добавить";
            this.addProcessorButton.UseVisualStyleBackColor = true;
            this.addProcessorButton.Click += new System.EventHandler(this.addProcessorButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.Location = new System.Drawing.Point(440, 391);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(92, 29);
            this.reloadButton.TabIndex = 10;
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
            this.showMoreButton.TabIndex = 9;
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
            this.goBackButton.TabIndex = 8;
            this.goBackButton.Text = "НАЗАД";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // processorsDataGrid
            // 
            this.processorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processorsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.procName,
            this.NumOfCores,
            this.ClockFrequency});
            this.processorsDataGrid.Location = new System.Drawing.Point(140, 78);
            this.processorsDataGrid.Name = "processorsDataGrid";
            this.processorsDataGrid.RowHeadersVisible = false;
            this.processorsDataGrid.Size = new System.Drawing.Size(574, 300);
            this.processorsDataGrid.TabIndex = 7;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // procName
            // 
            this.procName.FillWeight = 250F;
            this.procName.HeaderText = "Название";
            this.procName.Name = "procName";
            this.procName.ReadOnly = true;
            this.procName.Width = 250;
            // 
            // NumOfCores
            // 
            this.NumOfCores.FillWeight = 160F;
            this.NumOfCores.HeaderText = "Количество ядер";
            this.NumOfCores.Name = "NumOfCores";
            this.NumOfCores.ReadOnly = true;
            this.NumOfCores.Width = 160;
            // 
            // ClockFrequency
            // 
            this.ClockFrequency.FillWeight = 160F;
            this.ClockFrequency.HeaderText = "Тактовая частота";
            this.ClockFrequency.Name = "ClockFrequency";
            this.ClockFrequency.Width = 160;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // AdminShowCPUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addProcessorButton);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.showMoreButton);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.processorsDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminShowCPUsForm";
            this.Text = "\"Premium PC\". Администратор. Просмотр процессоров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminShowCPUsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.processorsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addProcessorButton;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button showMoreButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.DataGridView processorsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn procName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfCores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockFrequency;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}