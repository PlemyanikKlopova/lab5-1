namespace ИС_Музыкальная_школа_3
{
    partial class Сотрудники
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database4rDataSet = new ИС_Музыкальная_школа_3.Database4rDataSet();
            this.сотрудникиTableAdapter = new ИС_Музыкальная_школа_3.Database4rDataSetTableAdapters.СотрудникиTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.иДСотрудникиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияиномерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иДПолDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.полBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_lastDataSet = new ИС_Музыкальная_школа_3.Database_lastDataSet();
            this.иДДолжностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.должностьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaselastDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter1 = new ИС_Музыкальная_школа_3.Database_lastDataSetTableAdapters.СотрудникиTableAdapter();
            this.должностьTableAdapter = new ИС_Музыкальная_школа_3.Database_lastDataSetTableAdapters.ДолжностьTableAdapter();
            this.полTableAdapter = new ИС_Музыкальная_школа_3.Database_lastDataSetTableAdapters.ПолTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4rDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_lastDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselastDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.database4rDataSet;
            // 
            // database4rDataSet
            // 
            this.database4rDataSet.DataSetName = "Database4rDataSet";
            this.database4rDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.иДСотрудникиDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.серияиномерпаспортаDataGridViewTextBoxColumn,
            this.иДПолDataGridViewTextBoxColumn,
            this.иДДолжностьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сотрудникиBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(873, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // иДСотрудникиDataGridViewTextBoxColumn
            // 
            this.иДСотрудникиDataGridViewTextBoxColumn.DataPropertyName = "ИД_Сотрудники";
            this.иДСотрудникиDataGridViewTextBoxColumn.HeaderText = "ИД_Сотрудники";
            this.иДСотрудникиDataGridViewTextBoxColumn.Name = "иДСотрудникиDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            // 
            // серияиномерпаспортаDataGridViewTextBoxColumn
            // 
            this.серияиномерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия_и_номер_паспорта";
            this.серияиномерпаспортаDataGridViewTextBoxColumn.HeaderText = "Серия и номер паспорта";
            this.серияиномерпаспортаDataGridViewTextBoxColumn.Name = "серияиномерпаспортаDataGridViewTextBoxColumn";
            // 
            // иДПолDataGridViewTextBoxColumn
            // 
            this.иДПолDataGridViewTextBoxColumn.DataPropertyName = "ИД_Пол";
            this.иДПолDataGridViewTextBoxColumn.DataSource = this.полBindingSource;
            this.иДПолDataGridViewTextBoxColumn.DisplayMember = "Наименование_пола";
            this.иДПолDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.иДПолDataGridViewTextBoxColumn.Name = "иДПолDataGridViewTextBoxColumn";
            this.иДПолDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.иДПолDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.иДПолDataGridViewTextBoxColumn.ValueMember = "ИД_Пол";
            // 
            // полBindingSource
            // 
            this.полBindingSource.DataMember = "Пол";
            this.полBindingSource.DataSource = this.database_lastDataSet;
            // 
            // database_lastDataSet
            // 
            this.database_lastDataSet.DataSetName = "Database_lastDataSet";
            this.database_lastDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // иДДолжностьDataGridViewTextBoxColumn
            // 
            this.иДДолжностьDataGridViewTextBoxColumn.DataPropertyName = "ИД_Должность";
            this.иДДолжностьDataGridViewTextBoxColumn.DataSource = this.должностьBindingSource;
            this.иДДолжностьDataGridViewTextBoxColumn.DisplayMember = "Наименование_должности";
            this.иДДолжностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.иДДолжностьDataGridViewTextBoxColumn.Name = "иДДолжностьDataGridViewTextBoxColumn";
            this.иДДолжностьDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.иДДолжностьDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.иДДолжностьDataGridViewTextBoxColumn.ValueMember = "ИД_Должность";
            // 
            // должностьBindingSource
            // 
            this.должностьBindingSource.DataMember = "Должность";
            this.должностьBindingSource.DataSource = this.database_lastDataSet;
            // 
            // сотрудникиBindingSource1
            // 
            this.сотрудникиBindingSource1.DataMember = "Сотрудники";
            this.сотрудникиBindingSource1.DataSource = this.databaselastDataSetBindingSource;
            // 
            // databaselastDataSetBindingSource
            // 
            this.databaselastDataSetBindingSource.DataSource = this.database_lastDataSet;
            this.databaselastDataSetBindingSource.Position = 0;
            // 
            // сотрудникиTableAdapter1
            // 
            this.сотрудникиTableAdapter1.ClearBeforeFill = true;
            // 
            // должностьTableAdapter
            // 
            this.должностьTableAdapter.ClearBeforeFill = true;
            // 
            // полTableAdapter
            // 
            this.полTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 331);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 21);
            this.button3.TabIndex = 6;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 307);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 21);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Дополнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Сотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 364);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Сотрудники";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Сотрудники_Load);
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database4rDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.полBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_lastDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaselastDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Database4rDataSet database4rDataSet;
        public System.Windows.Forms.BindingSource сотрудникиBindingSource;
        public Database4rDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.BindingSource databaselastDataSetBindingSource;
        public Database_lastDataSet database_lastDataSet;
        public System.Windows.Forms.BindingSource сотрудникиBindingSource1;
        public Database_lastDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter1;
        public System.Windows.Forms.BindingSource должностьBindingSource;
        public Database_lastDataSetTableAdapters.ДолжностьTableAdapter должностьTableAdapter;
        public System.Windows.Forms.BindingSource полBindingSource;
        public Database_lastDataSetTableAdapters.ПолTableAdapter полTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn иДСотрудникиDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn серияиномерпаспортаDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn иДПолDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewComboBoxColumn иДДолжностьDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.ComponentModel.IContainer components;
    }
}