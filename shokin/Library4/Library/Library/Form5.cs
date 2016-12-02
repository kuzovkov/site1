using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class ViewByBooks : Form
    {
        public ViewByBooks()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDBDataSet);

        }

        private void ViewByBooks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Issuance". При необходимости она может быть перемещена или удалена.
            this.issuanceTableAdapter.Fill(this.libraryDBDataSet.Issuance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Issuance". При необходимости она может быть перемещена или удалена.
            this.issuanceTableAdapter.Fill(this.libraryDBDataSet.Issuance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Issuance". При необходимости она может быть перемещена или удалена.
            this.issuanceTableAdapter.Fill(this.libraryDBDataSet.Issuance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDBDataSet.Books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void booksBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
