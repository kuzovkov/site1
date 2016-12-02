namespace Library
{
    partial class MainWindiw
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
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDBDataSet = new Library.LibraryDBDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.readersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksTableAdapter = new Library.LibraryDBDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Library.LibraryDBDataSetTableAdapters.TableAdapterManager();
            this.booksIssuanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuanceTableAdapter = new Library.LibraryDBDataSetTableAdapters.IssuanceTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssuanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDBDataSet;
            // 
            // libraryDBDataSet
            // 
            this.libraryDBDataSet.DataSetName = "LibraryDBDataSet";
            this.libraryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.editToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem1,
            this.readersToolStripMenuItem,
            this.issuanceToolStripMenuItem1});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.booksToolStripMenuItem.Text = "Edit";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem1
            // 
            this.booksToolStripMenuItem1.Name = "booksToolStripMenuItem1";
            this.booksToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.booksToolStripMenuItem1.Text = "Insert Books In DB";
            this.booksToolStripMenuItem1.Click += new System.EventHandler(this.booksToolStripMenuItem1_Click);
            // 
            // readersToolStripMenuItem
            // 
            this.readersToolStripMenuItem.Name = "readersToolStripMenuItem";
            this.readersToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.readersToolStripMenuItem.Text = "Insert Readers In DB";
            this.readersToolStripMenuItem.Click += new System.EventHandler(this.readersToolStripMenuItem_Click);
            // 
            // issuanceToolStripMenuItem1
            // 
            this.issuanceToolStripMenuItem1.Name = "issuanceToolStripMenuItem1";
            this.issuanceToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.issuanceToolStripMenuItem1.Text = "Add Issuance";
            this.issuanceToolStripMenuItem1.Click += new System.EventHandler(this.issuanceToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem2,
            this.readersToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // booksToolStripMenuItem2
            // 
            this.booksToolStripMenuItem2.Name = "booksToolStripMenuItem2";
            this.booksToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
            this.booksToolStripMenuItem2.Text = "By Books";
            this.booksToolStripMenuItem2.Click += new System.EventHandler(this.booksToolStripMenuItem2_Click);
            // 
            // readersToolStripMenuItem1
            // 
            this.readersToolStripMenuItem1.Name = "readersToolStripMenuItem1";
            this.readersToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.readersToolStripMenuItem1.Text = "By Readers";
            this.readersToolStripMenuItem1.Click += new System.EventHandler(this.readersToolStripMenuItem1_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
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
            // booksIssuanceBindingSource
            // 
            this.booksIssuanceBindingSource.DataMember = "Books_Issuance";
            this.booksIssuanceBindingSource.DataSource = this.booksBindingSource;
            // 
            // issuanceTableAdapter
            // 
            this.issuanceTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "Library Found";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainWindiw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindiw";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDBDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksIssuanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDBDataSet libraryDBDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDBDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem readersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuanceToolStripMenuItem1;
        private System.Windows.Forms.BindingSource booksIssuanceBindingSource;
        private LibraryDBDataSetTableAdapters.IssuanceTableAdapter issuanceTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}

