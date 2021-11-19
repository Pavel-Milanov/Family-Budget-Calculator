namespace FamilyBudget
{
    partial class Edit
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
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDatabaseDataSet1 = new FamilyBudget.SampleDatabaseDataSet();
            this.customerTableAdapter1 = new FamilyBudget.SampleDatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.sampleDatabaseDataSet2 = new FamilyBudget.SampleDatabaseDataSet();
            this.sampleDatabaseDataSet3 = new FamilyBudget.SampleDatabaseDataSet();
            this.sampleDatabaseDataSet4 = new FamilyBudget.SampleDatabaseDataSet();
            this.sampleDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.removeMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sampleDatabaseDataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDatabaseDataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.addMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDatabaseDataSet1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.sampleDatabaseDataSet1BindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(749, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добави";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(749, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редактирай";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(749, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изтрий";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(749, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = "Опресни";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.sampleDatabaseDataSet1;
            // 
            // sampleDatabaseDataSet1
            // 
            this.sampleDatabaseDataSet1.DataSetName = "SampleDatabaseDataSet";
            this.sampleDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // sampleDatabaseDataSet2
            // 
            this.sampleDatabaseDataSet2.DataSetName = "SampleDatabaseDataSet";
            this.sampleDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleDatabaseDataSet3
            // 
            this.sampleDatabaseDataSet3.DataSetName = "SampleDatabaseDataSet";
            this.sampleDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleDatabaseDataSet4
            // 
            this.sampleDatabaseDataSet4.DataSetName = "SampleDatabaseDataSet";
            this.sampleDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sampleDatabaseDataSet1BindingSource
            // 
            this.sampleDatabaseDataSet1BindingSource.DataSource = this.sampleDatabaseDataSet1;
            this.sampleDatabaseDataSet1BindingSource.Position = 0;
            // 
            // removeMoneyBindingSource
            // 
            this.removeMoneyBindingSource.DataSource = typeof(FamilyBudget.RemoveMoney);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.moneyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 358);
            this.dataGridView1.TabIndex = 5;
            // 
            // sampleDatabaseDataSet1BindingSource1
            // 
            this.sampleDatabaseDataSet1BindingSource1.DataSource = this.sampleDatabaseDataSet1;
            this.sampleDatabaseDataSet1BindingSource1.Position = 0;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.sampleDatabaseDataSet1BindingSource1;
            // 
            // sampleDatabaseDataSet1BindingSource2
            // 
            this.sampleDatabaseDataSet1BindingSource2.DataSource = this.sampleDatabaseDataSet1;
            this.sampleDatabaseDataSet1BindingSource2.Position = 0;
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataMember = "Customer";
            this.customerBindingSource2.DataSource = this.sampleDatabaseDataSet1BindingSource2;
            // 
            // addMoneyBindingSource
            // 
            this.addMoneyBindingSource.DataSource = typeof(FamilyBudget.AddMoney);
            // 
            // sampleDatabaseDataSet1BindingSource3
            // 
            this.sampleDatabaseDataSet1BindingSource3.DataSource = this.sampleDatabaseDataSet1;
            this.sampleDatabaseDataSet1BindingSource3.Position = 0;
            // 
            // sampleDatabaseDataSet1BindingSource4
            // 
            this.sampleDatabaseDataSet1BindingSource4.DataSource = this.sampleDatabaseDataSet1;
            this.sampleDatabaseDataSet1BindingSource4.Position = 0;
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataMember = "Customer";
            this.customerBindingSource3.DataSource = this.sampleDatabaseDataSet1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // moneyDataGridViewTextBoxColumn
            // 
            this.moneyDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.moneyDataGridViewTextBoxColumn.HeaderText = "Money";
            this.moneyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moneyDataGridViewTextBoxColumn.Name = "moneyDataGridViewTextBoxColumn";
            this.moneyDataGridViewTextBoxColumn.Width = 125;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.removeMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleDatabaseDataSet1BindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource removeMoneyBindingSource;
        private System.Windows.Forms.BindingSource moneyBindingSource;
        //private Database2DataSet1 database2DataSet1;
        private System.Windows.Forms.BindingSource table1BindingSource;
        //private Database2DataSet1TableAdapters.Table1TableAdapter table1TableAdapter;
        private SampleDatabaseDataSet sampleDatabaseDataSet1;
        private SampleDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private SampleDatabaseDataSet sampleDatabaseDataSet2;
        private SampleDatabaseDataSet sampleDatabaseDataSet3;
        private SampleDatabaseDataSet sampleDatabaseDataSet4;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSet1BindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSet1BindingSource2;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource addMoneyBindingSource;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSet1BindingSource3;
        private System.Windows.Forms.BindingSource sampleDatabaseDataSet1BindingSource4;
    }
}