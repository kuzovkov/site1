namespace Library
{
    partial class IssuancesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuancesWindow));
            this.issuanceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.issuanceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.issuanceDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.issuanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuanceTableAdapter = new Library.LibraryDBDataSetTableAdapters.IssuanceTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.booksTableAdapter = new Library.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.readersTableAdapter = new Library.LibraryDBDataSetTableAdapters.ReadersTableAdapter();
            this.dataTable1TableAdapter = new Library.LibraryDBDataSetTableAdapters.DataTable1TableAdapter();
            this.issuanceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateWithdrawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDepositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingNavigator)).BeginInit();
            this.issuanceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // issuanceBindingNavigator
            // 
            this.issuanceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.issuanceBindingNavigator.BindingSource = this.issuanceBindingSource;
            this.issuanceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.issuanceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.issuanceBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.issuanceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.issuanceBindingNavigatorSaveItem});
            this.issuanceBindingNavigator.Location = new System.Drawing.Point(12, 484);
            this.issuanceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.issuanceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.issuanceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.issuanceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.issuanceBindingNavigator.Name = "issuanceBindingNavigator";
            this.issuanceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.issuanceBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.issuanceBindingNavigator.TabIndex = 0;
            this.issuanceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // issuanceBindingNavigatorSaveItem
            // 
            this.issuanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.issuanceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("issuanceBindingNavigatorSaveItem.Image")));
            this.issuanceBindingNavigatorSaveItem.Name = "issuanceBindingNavigatorSaveItem";
            this.issuanceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.issuanceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.issuanceBindingNavigatorSaveItem.Click += new System.EventHandler(this.issuanceBindingNavigatorSaveItem_Click_1);
            // 
            // issuanceDataGridView
            // 
            this.issuanceDataGridView.AutoGenerateColumns = false;
            this.issuanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issuanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.issuanceIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.nameLastNameDataGridViewTextBoxColumn,
            this.dateWithdrawDataGridViewTextBoxColumn,
            this.dateDepositDataGridViewTextBoxColumn});
            this.issuanceDataGridView.DataSource = this.dataTable1BindingSource;
            this.issuanceDataGridView.Location = new System.Drawing.Point(12, 86);
            this.issuanceDataGridView.Name = "issuanceDataGridView";
            this.issuanceDataGridView.Size = new System.Drawing.Size(549, 381);
            this.issuanceDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Editing Issuances";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issuanceBindingSource
            // 
            this.issuanceBindingSource.DataMember = "Issuance";
            this.issuanceBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // issuanceTableAdapter
            // 
            this.issuanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.IssuanceTableAdapter = this.issuanceTableAdapter;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // issuanceIDDataGridViewTextBoxColumn
            // 
            this.issuanceIDDataGridViewTextBoxColumn.DataPropertyName = "IssuanceID";
            this.issuanceIDDataGridViewTextBoxColumn.HeaderText = "IssuanceID";
            this.issuanceIDDataGridViewTextBoxColumn.Name = "issuanceIDDataGridViewTextBoxColumn";
            this.issuanceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameLastNameDataGridViewTextBoxColumn
            // 
            this.nameLastNameDataGridViewTextBoxColumn.DataPropertyName = "NameLastName";
            this.nameLastNameDataGridViewTextBoxColumn.HeaderText = "NameLastName";
            this.nameLastNameDataGridViewTextBoxColumn.Name = "nameLastNameDataGridViewTextBoxColumn";
            this.nameLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateWithdrawDataGridViewTextBoxColumn
            // 
            this.dateWithdrawDataGridViewTextBoxColumn.DataPropertyName = "DateWithdraw";
            this.dateWithdrawDataGridViewTextBoxColumn.HeaderText = "DateWithdraw";
            this.dateWithdrawDataGridViewTextBoxColumn.Name = "dateWithdrawDataGridViewTextBoxColumn";
            this.dateWithdrawDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDepositDataGridViewTextBoxColumn
            // 
            this.dateDepositDataGridViewTextBoxColumn.DataPropertyName = "DateDeposit";
            this.dateDepositDataGridViewTextBoxColumn.HeaderText = "DateDeposit";
            this.dateDepositDataGridViewTextBoxColumn.Name = "dateDepositDataGridViewTextBoxColumn";
            this.dateDepositDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IssuancesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.issuanceDataGridView);
            this.Controls.Add(this.issuanceBindingNavigator);
            this.Name = "IssuancesWindow";
            this.Text = "Add Issuance";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingNavigator)).EndInit();
            this.issuanceBindingNavigator.ResumeLayout(false);
            this.issuanceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private LibraryDBDataSetTableAdapters.IssuanceTableAdapter issuanceTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDBDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource issuanceBindingSource;
        private System.Windows.Forms.BindingNavigator issuanceBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton issuanceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView issuanceDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private LibraryDBDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuanceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateWithdrawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDepositDataGridViewTextBoxColumn;
    }
}