namespace Library
{
    partial class ReadersWindow
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
            System.Windows.Forms.Label nameLastNameLabel;
            System.Windows.Forms.Label _OfTiketLabel;
            System.Windows.Forms.Label birthDayLabel;
            System.Windows.Forms.Label professionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadersWindow));
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.readersTableAdapter = new Library.LibraryDBDataSetTableAdapters.ReadersTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.readersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.readersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameLastNameTextBox = new System.Windows.Forms.TextBox();
            this._OfTiketTextBox = new System.Windows.Forms.TextBox();
            this.birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.professionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nameLastNameLabel = new System.Windows.Forms.Label();
            _OfTiketLabel = new System.Windows.Forms.Label();
            birthDayLabel = new System.Windows.Forms.Label();
            professionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingNavigator)).BeginInit();
            this.readersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLastNameLabel
            // 
            nameLastNameLabel.AutoSize = true;
            nameLastNameLabel.Location = new System.Drawing.Point(12, 74);
            nameLastNameLabel.Name = "nameLastNameLabel";
            nameLastNameLabel.Size = new System.Drawing.Size(92, 13);
            nameLastNameLabel.TabIndex = 3;
            nameLastNameLabel.Text = "Name Last Name:";
            // 
            // _OfTiketLabel
            // 
            _OfTiketLabel.AutoSize = true;
            _OfTiketLabel.Location = new System.Drawing.Point(12, 100);
            _OfTiketLabel.Name = "_OfTiketLabel";
            _OfTiketLabel.Size = new System.Drawing.Size(59, 13);
            _OfTiketLabel.TabIndex = 5;
            _OfTiketLabel.Text = "№Of Tiket:";
            // 
            // birthDayLabel
            // 
            birthDayLabel.AutoSize = true;
            birthDayLabel.Location = new System.Drawing.Point(12, 127);
            birthDayLabel.Name = "birthDayLabel";
            birthDayLabel.Size = new System.Drawing.Size(53, 13);
            birthDayLabel.TabIndex = 7;
            birthDayLabel.Text = "Birth Day:";
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Location = new System.Drawing.Point(12, 152);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new System.Drawing.Size(59, 13);
            professionLabel.TabIndex = 9;
            professionLabel.Text = "Profession:";
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.IssuanceTableAdapter = null;
            this.tableAdapterManager.ReadersTableAdapter = this.readersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // readersBindingNavigator
            // 
            this.readersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.readersBindingNavigator.BindingSource = this.readersBindingSource;
            this.readersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.readersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.readersBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.readersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.readersBindingNavigatorSaveItem});
            this.readersBindingNavigator.Location = new System.Drawing.Point(15, 181);
            this.readersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.readersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.readersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.readersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.readersBindingNavigator.Name = "readersBindingNavigator";
            this.readersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.readersBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.readersBindingNavigator.TabIndex = 0;
            this.readersBindingNavigator.Text = "bindingNavigator1";
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
            // readersBindingNavigatorSaveItem
            // 
            this.readersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.readersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("readersBindingNavigatorSaveItem.Image")));
            this.readersBindingNavigatorSaveItem.Name = "readersBindingNavigatorSaveItem";
            this.readersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.readersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.readersBindingNavigatorSaveItem.Click += new System.EventHandler(this.readersBindingNavigatorSaveItem_Click);
            // 
            // nameLastNameTextBox
            // 
            this.nameLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "NameLastName", true));
            this.nameLastNameTextBox.Location = new System.Drawing.Point(110, 71);
            this.nameLastNameTextBox.Name = "nameLastNameTextBox";
            this.nameLastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameLastNameTextBox.TabIndex = 4;
            // 
            // _OfTiketTextBox
            // 
            this._OfTiketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "№OfTiket", true));
            this._OfTiketTextBox.Location = new System.Drawing.Point(110, 97);
            this._OfTiketTextBox.Name = "_OfTiketTextBox";
            this._OfTiketTextBox.Size = new System.Drawing.Size(200, 20);
            this._OfTiketTextBox.TabIndex = 6;
            // 
            // birthDayDateTimePicker
            // 
            this.birthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.readersBindingSource, "BirthDay", true));
            this.birthDayDateTimePicker.Location = new System.Drawing.Point(110, 123);
            this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
            this.birthDayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthDayDateTimePicker.TabIndex = 8;
            // 
            // professionTextBox
            // 
            this.professionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.readersBindingSource, "Profession", true));
            this.professionTextBox.Location = new System.Drawing.Point(110, 149);
            this.professionTextBox.Name = "professionTextBox";
            this.professionTextBox.Size = new System.Drawing.Size(200, 20);
            this.professionTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adding Readers into DB";
            // 
            // ReadersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLastNameLabel);
            this.Controls.Add(this.nameLastNameTextBox);
            this.Controls.Add(_OfTiketLabel);
            this.Controls.Add(this._OfTiketTextBox);
            this.Controls.Add(birthDayLabel);
            this.Controls.Add(this.birthDayDateTimePicker);
            this.Controls.Add(professionLabel);
            this.Controls.Add(this.professionTextBox);
            this.Controls.Add(this.readersBindingNavigator);
            this.Name = "ReadersWindow";
            this.Text = "Insert Readers In DB";
            this.Load += new System.EventHandler(this.ReadersWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingNavigator)).EndInit();
            this.readersBindingNavigator.ResumeLayout(false);
            this.readersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private LibraryDBDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator readersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton readersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameLastNameTextBox;
        private System.Windows.Forms.TextBox _OfTiketTextBox;
        private System.Windows.Forms.DateTimePicker birthDayDateTimePicker;
        private System.Windows.Forms.TextBox professionTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}