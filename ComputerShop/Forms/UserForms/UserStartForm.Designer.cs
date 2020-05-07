namespace ComputerShop
{
    partial class UserStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStartForm));
            this.showMoreButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reloadButton = new System.Windows.Forms.Button();
            this.computersDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videocardIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videocardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goBackButton = new System.Windows.Forms.Button();
            this.accountButton = new System.Windows.Forms.Button();
            this.ramCheckBox = new System.Windows.Forms.CheckBox();
            this.videoCheckBox = new System.Windows.Forms.CheckBox();
            this.procCheckBox = new System.Windows.Forms.CheckBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ramComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.videocardComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.processorComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // showMoreButton
            // 
            this.showMoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showMoreButton.Location = new System.Drawing.Point(12, 488);
            this.showMoreButton.Name = "showMoreButton";
            this.showMoreButton.Size = new System.Drawing.Size(92, 29);
            this.showMoreButton.TabIndex = 34;
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
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // reloadButton
            // 
            this.reloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reloadButton.Location = new System.Drawing.Point(122, 488);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(92, 29);
            this.reloadButton.TabIndex = 35;
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
            this.computersDataGrid.Location = new System.Drawing.Point(12, 182);
            this.computersDataGrid.Name = "computersDataGrid";
            this.computersDataGrid.ReadOnly = true;
            this.computersDataGrid.RowHeadersVisible = false;
            this.computersDataGrid.Size = new System.Drawing.Size(830, 300);
            this.computersDataGrid.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // processorIdDataGridViewTextBoxColumn
            // 
            this.processorIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessorId";
            this.processorIdDataGridViewTextBoxColumn.HeaderText = "ProcessorId";
            this.processorIdDataGridViewTextBoxColumn.Name = "processorIdDataGridViewTextBoxColumn";
            this.processorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.processorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // videocardIdDataGridViewTextBoxColumn
            // 
            this.videocardIdDataGridViewTextBoxColumn.DataPropertyName = "VideocardId";
            this.videocardIdDataGridViewTextBoxColumn.HeaderText = "VideocardId";
            this.videocardIdDataGridViewTextBoxColumn.Name = "videocardIdDataGridViewTextBoxColumn";
            this.videocardIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.videocardIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // rAMIdDataGridViewTextBoxColumn
            // 
            this.rAMIdDataGridViewTextBoxColumn.DataPropertyName = "RAMId";
            this.rAMIdDataGridViewTextBoxColumn.HeaderText = "RAMId";
            this.rAMIdDataGridViewTextBoxColumn.Name = "rAMIdDataGridViewTextBoxColumn";
            this.rAMIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.rAMIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // imagePathDataGridViewTextBoxColumn
            // 
            this.imagePathDataGridViewTextBoxColumn.DataPropertyName = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.HeaderText = "ImagePath";
            this.imagePathDataGridViewTextBoxColumn.Name = "imagePathDataGridViewTextBoxColumn";
            this.imagePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.imagePathDataGridViewTextBoxColumn.Visible = false;
            // 
            // processorDataGridViewTextBoxColumn
            // 
            this.processorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.processorDataGridViewTextBoxColumn.DataPropertyName = "Processor";
            this.processorDataGridViewTextBoxColumn.HeaderText = "Процессор";
            this.processorDataGridViewTextBoxColumn.Name = "processorDataGridViewTextBoxColumn";
            this.processorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // videocardDataGridViewTextBoxColumn
            // 
            this.videocardDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.videocardDataGridViewTextBoxColumn.DataPropertyName = "Videocard";
            this.videocardDataGridViewTextBoxColumn.HeaderText = "Видеокарта";
            this.videocardDataGridViewTextBoxColumn.Name = "videocardDataGridViewTextBoxColumn";
            this.videocardDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAMDataGridViewTextBoxColumn
            // 
            this.rAMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rAMDataGridViewTextBoxColumn.DataPropertyName = "RAM";
            this.rAMDataGridViewTextBoxColumn.HeaderText = "ОЗУ";
            this.rAMDataGridViewTextBoxColumn.Name = "rAMDataGridViewTextBoxColumn";
            this.rAMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(ComputerShop.Computer);
            // 
            // goBackButton
            // 
            this.goBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 31;
            this.goBackButton.Text = "ВЫЙТИ";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountButton.Location = new System.Drawing.Point(748, 12);
            this.accountButton.Name = "accountButton";
            this.accountButton.Size = new System.Drawing.Size(94, 23);
            this.accountButton.TabIndex = 36;
            this.accountButton.Text = "ПРОФИЛЬ";
            this.accountButton.UseVisualStyleBackColor = true;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // ramCheckBox
            // 
            this.ramCheckBox.AutoSize = true;
            this.ramCheckBox.Location = new System.Drawing.Point(483, 119);
            this.ramCheckBox.Name = "ramCheckBox";
            this.ramCheckBox.Size = new System.Drawing.Size(81, 17);
            this.ramCheckBox.TabIndex = 75;
            this.ramCheckBox.Text = "Учитывать";
            this.ramCheckBox.UseVisualStyleBackColor = true;
            // 
            // videoCheckBox
            // 
            this.videoCheckBox.AutoSize = true;
            this.videoCheckBox.Location = new System.Drawing.Point(322, 119);
            this.videoCheckBox.Name = "videoCheckBox";
            this.videoCheckBox.Size = new System.Drawing.Size(81, 17);
            this.videoCheckBox.TabIndex = 74;
            this.videoCheckBox.Text = "Учитывать";
            this.videoCheckBox.UseVisualStyleBackColor = true;
            // 
            // procCheckBox
            // 
            this.procCheckBox.AutoSize = true;
            this.procCheckBox.Location = new System.Drawing.Point(112, 119);
            this.procCheckBox.Name = "procCheckBox";
            this.procCheckBox.Size = new System.Drawing.Size(81, 17);
            this.procCheckBox.TabIndex = 73;
            this.procCheckBox.Text = "Учитывать";
            this.procCheckBox.UseVisualStyleBackColor = true;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.Location = new System.Drawing.Point(598, 138);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(92, 29);
            this.filterButton.TabIndex = 72;
            this.filterButton.Text = "Показать";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(429, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "ОЗУ:";
            // 
            // ramComboBox
            // 
            this.ramComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ramComboBox.DropDownWidth = 250;
            this.ramComboBox.FormattingEnabled = true;
            this.ramComboBox.Location = new System.Drawing.Point(474, 142);
            this.ramComboBox.Name = "ramComboBox";
            this.ramComboBox.Size = new System.Drawing.Size(100, 21);
            this.ramComboBox.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(215, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Видеокарта:";
            // 
            // videocardComboBox
            // 
            this.videocardComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videocardComboBox.DropDownWidth = 400;
            this.videocardComboBox.FormattingEnabled = true;
            this.videocardComboBox.Location = new System.Drawing.Point(311, 142);
            this.videocardComboBox.Name = "videocardComboBox";
            this.videocardComboBox.Size = new System.Drawing.Size(100, 21);
            this.videocardComboBox.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 67;
            this.label3.Text = "Процессор:";
            // 
            // processorComboBox
            // 
            this.processorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processorComboBox.DropDownWidth = 120;
            this.processorComboBox.Location = new System.Drawing.Point(101, 142);
            this.processorComboBox.Name = "processorComboBox";
            this.processorComboBox.Size = new System.Drawing.Size(100, 21);
            this.processorComboBox.TabIndex = 66;
            // 
            // UserStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 525);
            this.Controls.Add(this.ramCheckBox);
            this.Controls.Add(this.videoCheckBox);
            this.Controls.Add(this.procCheckBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ramComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.videocardComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.processorComboBox);
            this.Controls.Add(this.accountButton);
            this.Controls.Add(this.showMoreButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.computersDataGrid);
            this.Controls.Add(this.goBackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserStartForm";
            this.Text = "\"Premium PC\". Пользователь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserStartForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button showMoreButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videocardDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn processorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAMIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn videocardIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView computersDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button accountButton;
        private System.Windows.Forms.CheckBox ramCheckBox;
        private System.Windows.Forms.CheckBox videoCheckBox;
        private System.Windows.Forms.CheckBox procCheckBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ramComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox videocardComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox processorComboBox;
    }
}