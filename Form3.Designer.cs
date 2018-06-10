namespace PPiatekWindowsFormsHelloWorld2
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.osobyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imieNazwiskoDB1DataSet1 = new PPiatekWindowsFormsHelloWorld2.ImieNazwiskoDB1DataSet1();
            this.imieNazwiskoDB1DataSet = new PPiatekWindowsFormsHelloWorld2.ImieNazwiskoDB1DataSet();
            this.osobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobyTableAdapter = new PPiatekWindowsFormsHelloWorld2.ImieNazwiskoDB1DataSetTableAdapters.OsobyTableAdapter();
            this.osobyTableAdapter1 = new PPiatekWindowsFormsHelloWorld2.ImieNazwiskoDB1DataSet1TableAdapters.OsobyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.piotrPiatekDB1DataSet = new PPiatekWindowsFormsHelloWorld2.PiotrPiatekDB1DataSet();
            this.piotrPiatekDB1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieNazwiskoDB1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieNazwiskoDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piotrPiatekDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piotrPiatekDB1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.osobyBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // osobyBindingSource1
            // 
            this.osobyBindingSource1.DataMember = "Osoby";
            this.osobyBindingSource1.DataSource = this.imieNazwiskoDB1DataSet1;
            // 
            // imieNazwiskoDB1DataSet1
            // 
            this.imieNazwiskoDB1DataSet1.DataSetName = "ImieNazwiskoDB1DataSet1";
            this.imieNazwiskoDB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imieNazwiskoDB1DataSet
            // 
            this.imieNazwiskoDB1DataSet.DataSetName = "ImieNazwiskoDB1DataSet";
            this.imieNazwiskoDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osobyBindingSource
            // 
            this.osobyBindingSource.DataMember = "Osoby";
            this.osobyBindingSource.DataSource = this.imieNazwiskoDB1DataSet;
            // 
            // osobyTableAdapter
            // 
            this.osobyTableAdapter.ClearBeforeFill = true;
            // 
            // osobyTableAdapter1
            // 
            this.osobyTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // piotrPiatekDB1DataSet
            // 
            this.piotrPiatekDB1DataSet.DataSetName = "PiotrPiatekDB1DataSet";
            this.piotrPiatekDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // piotrPiatekDB1DataSetBindingSource
            // 
            this.piotrPiatekDB1DataSetBindingSource.DataSource = this.piotrPiatekDB1DataSet;
            this.piotrPiatekDB1DataSetBindingSource.Position = 0;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieNazwiskoDB1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieNazwiskoDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piotrPiatekDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piotrPiatekDB1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ImieNazwiskoDB1DataSet imieNazwiskoDB1DataSet;
        private System.Windows.Forms.BindingSource osobyBindingSource;
        private ImieNazwiskoDB1DataSetTableAdapters.OsobyTableAdapter osobyTableAdapter;
        private ImieNazwiskoDB1DataSet1 imieNazwiskoDB1DataSet1;
        private System.Windows.Forms.BindingSource osobyBindingSource1;
        private ImieNazwiskoDB1DataSet1TableAdapters.OsobyTableAdapter osobyTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource piotrPiatekDB1DataSetBindingSource;
        private PiotrPiatekDB1DataSet piotrPiatekDB1DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}