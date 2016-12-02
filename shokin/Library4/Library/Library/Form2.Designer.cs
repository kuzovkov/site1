namespace Library
{
    partial class BookWindow
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
            System.Windows.Forms.Label bookNameLabel;
            System.Windows.Forms.Label auhtorLabel;
            System.Windows.Forms.Label yearOfPublisLabel;
            System.Windows.Forms.Label pagesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookWindow));
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new Library.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.auhtorTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.yearOfPublisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            bookNameLabel = new System.Windows.Forms.Label();
            auhtorLabel = new System.Windows.Forms.Label();
            yearOfPublisLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).BeginInit();
            this.booksBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new System.Drawing.Point(25, 74);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new System.Drawing.Size(66, 13);
            bookNameLabel.TabIndex = 3;
            bookNameLabel.Text = "Book Name:";
            // 
            // auhtorLabel
            // 
            auhtorLabel.AutoSize = true;
            auhtorLabel.Location = new System.Drawing.Point(25, 100);
            auhtorLabel.Name = "auhtorLabel";
            auhtorLabel.Size = new System.Drawing.Size(41, 13);
            auhtorLabel.TabIndex = 5;
            auhtorLabel.Text = "Auhtor:";
            // 
            // yearOfPublisLabel
            // 
            yearOfPublisLabel.AutoSize = true;
            yearOfPublisLabel.Location = new System.Drawing.Point(25, 126);
            yearOfPublisLabel.Name = "yearOfPublisLabel";
            yearOfPublisLabel.Size = new System.Drawing.Size(77, 13);
            yearOfPublisLabel.TabIndex = 7;
            yearOfPublisLabel.Text = "Year Of Publis:";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(25, 152);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(40, 13);
            pagesLabel.TabIndex = 9;
            pagesLabel.Text = "Pages:";
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.IssuanceTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksBindingNavigator
            // 
            this.booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booksBindingNavigator.BindingSource = this.booksBindingSource;
            this.booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booksBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.booksBindingNavigatorSaveItem});
            this.booksBindingNavigator.Location = new System.Drawing.Point(9, 186);
            this.booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booksBindingNavigator.Name = "booksBindingNavigator";
            this.booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booksBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.booksBindingNavigator.TabIndex = 0;
            this.booksBindingNavigator.Text = "bindingNavigator1";
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
            // booksBindingNavigatorSaveItem
            // 
            this.booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booksBindingNavigatorSaveItem.Image")));
            this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
            this.booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.booksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.booksBindingNavigatorSaveItem_Click);
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "BookName", true));
            this.bookNameTextBox.Location = new System.Drawing.Point(108, 71);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(187, 20);
            this.bookNameTextBox.TabIndex = 4;
            // 
            // auhtorTextBox
            // 
            this.auhtorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Auhtor", true));
            this.auhtorTextBox.Location = new System.Drawing.Point(108, 97);
            this.auhtorTextBox.Name = "auhtorTextBox";
            this.auhtorTextBox.Size = new System.Drawing.Size(187, 20);
            this.auhtorTextBox.TabIndex = 6;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Pages", true));
            this.pagesTextBox.Location = new System.Drawing.Point(108, 149);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(187, 20);
            this.pagesTextBox.TabIndex = 10;
            // 
            // yearOfPublisDateTimePicker
            // 
            this.yearOfPublisDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.booksBindingSource, "YearOfPublis", true));
            this.yearOfPublisDateTimePicker.Location = new System.Drawing.Point(108, 123);
            this.yearOfPublisDateTimePicker.Name = "yearOfPublisDateTimePicker";
            this.yearOfPublisDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.yearOfPublisDateTimePicker.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adding Books into DB";
            // 
            // BookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yearOfPublisDateTimePicker);
            this.Controls.Add(bookNameLabel);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(auhtorLabel);
            this.Controls.Add(this.auhtorTextBox);
            this.Controls.Add(yearOfPublisLabel);
            this.Controls.Add(pagesLabel);
            this.Controls.Add(this.pagesTextBox);
            this.Controls.Add(this.booksBindingNavigator);
            this.Name = "BookWindow";
            this.Text = "Insert Books In DB";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).EndInit();
            this.booksBindingNavigator.ResumeLayout(false);
            this.booksBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator booksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton booksBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox auhtorTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.DateTimePicker yearOfPublisDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}