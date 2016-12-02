namespace Library
{
    partial class IssuanceByReader
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.readersDataGridView = new System.Windows.Forms.DataGridView();
            this.issuanceDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Library.LibraryDBDataSetTableAdapters.ReadersTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.issuanceTableAdapter = new Library.LibraryDBDataSetTableAdapters.IssuanceTableAdapter();
            this.readersIssuanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersIssuanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // readersDataGridView
            // 
            this.readersDataGridView.AutoGenerateColumns = false;
            this.readersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.readersDataGridView.DataSource = this.readersBindingSource;
            this.readersDataGridView.Location = new System.Drawing.Point(12, 51);
            this.readersDataGridView.Name = "readersDataGridView";
            this.readersDataGridView.Size = new System.Drawing.Size(546, 173);
            this.readersDataGridView.TabIndex = 1;
            // 
            // issuanceDataGridView
            // 
            this.issuanceDataGridView.AutoGenerateColumns = false;
            this.issuanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.issuanceDataGridView.DataSource = this.readersIssuanceBindingSource;
            this.issuanceDataGridView.Location = new System.Drawing.Point(12, 260);
            this.issuanceDataGridView.Name = "issuanceDataGridView";
            this.issuanceDataGridView.Size = new System.Drawing.Size(546, 141);
            this.issuanceDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issuances By Readers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IssuanceID";
            this.dataGridViewTextBoxColumn6.HeaderText = "IssuanceID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn7.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DeaderID";
            this.dataGridViewTextBoxColumn8.HeaderText = "DeaderID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DateWithdraw";
            this.dataGridViewTextBoxColumn9.HeaderText = "DateWithdraw";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DateDeposit";
            this.dataGridViewTextBoxColumn10.HeaderText = "DateDeposit";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // issuanceBindingSource
            // 
            this.issuanceBindingSource.DataMember = "Issuance";
            this.issuanceBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReaderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReaderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameLastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameLastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "№OfTiket";
            this.dataGridViewTextBoxColumn3.HeaderText = "№OfTiket";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BirthDay";
            this.dataGridViewTextBoxColumn4.HeaderText = "BirthDay";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Profession";
            this.dataGridViewTextBoxColumn5.HeaderText = "Profession";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.IssuanceTableAdapter = this.issuanceTableAdapter;
            this.tableAdapterManager.ReadersTableAdapter = this.readersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issuanceTableAdapter
            // 
            this.issuanceTableAdapter.ClearBeforeFill = true;
            // 
            // readersIssuanceBindingSource
            // 
            this.readersIssuanceBindingSource.DataMember = "Readers_Issuance";
            this.readersIssuanceBindingSource.DataSource = this.readersBindingSource;
            // 
            // IssuanceByReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.issuanceDataGridView);
            this.Controls.Add(this.readersDataGridView);
            this.Name = "IssuanceByReader";
            this.Text = "Issuances By Readers";
            this.Load += new System.EventHandler(this.IssuanceByReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersIssuanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private LibraryDBDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryDBDataSetTableAdapters.IssuanceTableAdapter issuanceTableAdapter;
        private System.Windows.Forms.DataGridView readersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource issuanceBindingSource;
        private System.Windows.Forms.DataGridView issuanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource readersIssuanceBindingSource;
    }
}