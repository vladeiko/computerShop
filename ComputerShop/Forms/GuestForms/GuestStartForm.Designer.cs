namespace ComputerShop
{
    partial class GuestStartForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestStartForm));
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videocardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videocardIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showMoreButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.computersDataGrid = new System.Windows.Forms.DataGridView();
            this.goBackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(ComputerShop.Computer);
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAMDataGridViewTextBoxColumn
            // 
            this.rAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rAMDataGridViewTextBoxColumn.DataPropertyName = "RAM";
            this.rAMDataGridViewTextBoxColumn.HeaderText = "ОЗУ";
            this.rAMDataGridViewTextBoxColumn.Name = "rAMDataGridViewTextBoxColumn";
            this.rAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videocardDataGridViewTextBoxColumn
            // 
            this.videocardDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.videocardDataGridViewTextBoxColumn.DataPropertyName = "Videocard";
            this.videocardDataGridViewTextBoxColumn.HeaderText = "Видеокарта";
            this.videocardDataGridViewTextBoxColumn.Name = "videocardDataGridViewTextBoxColumn";
            this.videocardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processorDataGridViewTextBoxColumn
            // 
            this.processorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.processorDataGridViewTextBoxColumn.DataPropertyName = "Processor";
            this.processorDataGridViewTextBoxColumn.HeaderText = "Процессор";
            this.processorDataGridViewTextBoxColumn.Name = "processorDataGridViewTextBoxColumn";
            this.processorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            this.imagePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAMIdDataGridViewTextBoxColumn
            // 
            this.rAMIdDataGridViewTextBoxColumn.DataPropertyName = "RAMId";
            this.rAMIdDataGridViewTextBoxColumn.HeaderText = "RAMId";
            this.rAMIdDataGridViewTextBoxColumn.Name = "rAMIdDataGridViewTextBoxColumn";
            this.rAMIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // videocardIdDataGridViewTextBoxColumn
            // 
            this.videocardIdDataGridViewTextBoxColumn.DataPropertyName = "VideocardId";
            this.videocardIdDataGridViewTextBoxColumn.HeaderText = "VideocardId";
            this.videocardIdDataGridViewTextBoxColumn.Name = "videocardIdDataGridViewTextBoxColumn";
            this.videocardIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.videocardIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // processorIdDataGridViewTextBoxColumn
            // 
            this.processorIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessorId";
            this.processorIdDataGridViewTextBoxColumn.HeaderText = "ProcessorId";
            this.processorIdDataGridViewTextBoxColumn.Name = "processorIdDataGridViewTextBoxColumn";
            this.processorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.processorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // showMoreButton
            // 
            this.showMoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showMoreButton.Location = new System.Drawing.Point(12, 470);
            this.showMoreButton.Name = "showMoreButton";
            this.showMoreButton.Size = new System.Drawing.Size(92, 29);
            this.showMoreButton.TabIndex = 40;
            this.showMoreButton.Text = "Подробнее";
            this.showMoreButton.UseVisualStyleBackColor = true;
            this.showMoreButton.Click += new System.EventHandler(this.showMoreButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(357, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.Location = new System.Drawing.Point(122, 470);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(92, 29);
            this.reloadButton.TabIndex = 41;
            this.reloadButton.Text = "Обновить";
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // computersDataGrid
            // 
            this.computersDataGrid.AutoGenerateColumns = false;
            this.computersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.processorIdDataGridViewTextBoxColumn,
            this.videocardIdDataGridViewTextBoxColumn,
            this.rAMIdDataGridViewTextBoxColumn,
            this.imagePathDataGridViewTextBoxColumn,
            this.processorDataGridViewTextBoxColumn,
            this.videocardDataGridViewTextBoxColumn,
            this.rAMDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.computersDataGrid.DataSource = this.computerBindingSource;
            this.computersDataGrid.Location = new System.Drawing.Point(12, 164);
            this.computersDataGrid.Name = "computersDataGrid";
            this.computersDataGrid.ReadOnly = true;
            this.computersDataGrid.RowHeadersVisible = false;
            this.computersDataGrid.Size = new System.Drawing.Size(830, 300);
            this.computersDataGrid.TabIndex = 38;
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 37;
            this.goBackButton.Text = "ВЫЙТИ";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Чтобы иметь возможность фильтровать таблицу, необходимо быть авторизированным пол" +
    "ьзователем";
            // 
            // GuestStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showMoreButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.computersDataGrid);
            this.Controls.Add(this.goBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestStartForm";
            this.Text = "\"Premium PC\". Гость";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestStartForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource computerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videocardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videocardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button showMoreButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.DataGridView computersDataGrid;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Label label1;
    }
}