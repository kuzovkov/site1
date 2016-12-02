namespace Library
{
    partial class ViewByBooks
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
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.issuanceTableAdapter = new Library.LibraryDBDataSetTableAdapters.IssuanceTableAdapter();
            this.issuanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.issuanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deaderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateWithdrawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDepositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksIssuanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssuanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = this.libraryDBDataSet;
            this.booksBindingSource.Position = 0;
            this.booksBindingSource.CurrentChanged += new System.EventHandler(this.booksBindingSource_CurrentChanged);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.IssuanceTableAdapter = this.issuanceTableAdapter;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // issuanceTableAdapter
            // 
            this.issuanceTableAdapter.ClearBeforeFill = true;
            // 
            // issuanceBindingSource
            // 
            this.issuanceBindingSource.DataMember = "Issuance";
            this.issuanceBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issuances Of Books";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryDBDataSet;
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.booksDataGridView.DataSource = this.booksBindingSource1;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 61);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(545, 232);
            this.booksDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn2.HeaderText = "BookName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Auhtor";
            this.dataGridViewTextBoxColumn3.HeaderText = "Auhtor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "YearOfPublis";
            this.dataGridViewTextBoxColumn4.HeaderText = "YearOfPublis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pages";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pages";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issuanceIDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.deaderIDDataGridViewTextBoxColumn,
            this.dateWithdrawDataGridViewTextBoxColumn,
            this.dateDepositDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksIssuanceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 332);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 157);
            this.dataGridView1.TabIndex = 4;
            // 
            // issuanceIDDataGridViewTextBoxColumn
            // 
            this.issuanceIDDataGridViewTextBoxColumn.DataPropertyName = "IssuanceID";
            this.issuanceIDDataGridViewTextBoxColumn.HeaderText = "IssuanceID";
            this.issuanceIDDataGridViewTextBoxColumn.Name = "issuanceIDDataGridViewTextBoxColumn";
            this.issuanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // deaderIDDataGridViewTextBoxColumn
            // 
            this.deaderIDDataGridViewTextBoxColumn.DataPropertyName = "DeaderID";
            this.deaderIDDataGridViewTextBoxColumn.HeaderText = "ReaderID";
            this.deaderIDDataGridViewTextBoxColumn.Name = "deaderIDDataGridViewTextBoxColumn";
            // 
            // dateWithdrawDataGridViewTextBoxColumn
            // 
            this.dateWithdrawDataGridViewTextBoxColumn.DataPropertyName = "DateWithdraw";
            this.dateWithdrawDataGridViewTextBoxColumn.HeaderText = "DateWithdraw";
            this.dateWithdrawDataGridViewTextBoxColumn.Name = "dateWithdrawDataGridViewTextBoxColumn";
            // 
            // dateDepositDataGridViewTextBoxColumn
            // 
            this.dateDepositDataGridViewTextBoxColumn.DataPropertyName = "DateDeposit";
            this.dateDepositDataGridViewTextBoxColumn.HeaderText = "DateDeposit";
            this.dateDepositDataGridViewTextBoxColumn.Name = "dateDepositDataGridViewTextBoxColumn";
            // 
            // booksIssuanceBindingSource
            // 
            this.booksIssuanceBindingSource.DataMember = "Books_Issuance";
            this.booksIssuanceBindingSource.DataSource = this.booksBindingSource1;
            // 
            // ViewByBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ViewByBooks";
            this.Text = "Issuances Of Books";
            this.Load += new System.EventHandler(this.ViewByBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssuanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryDBDataSetTableAdapters.IssuanceTableAdapter issuanceTableAdapter;
        private System.Windows.Forms.BindingSource issuanceBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource booksIssuanceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deaderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateWithdrawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDepositDataGridViewTextBoxColumn;
    }
}