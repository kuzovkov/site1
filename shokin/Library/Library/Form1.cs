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
    public partial class MainWindiw : Form
    {
        public MainWindiw()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Issuance". При необходимости она может быть перемещена или удалена.
            this.issuanceTableAdapter.Fill(this.libraryDBDataSet.Issuance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDBDataSet.Books);

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void booksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form booksForm = new BookWindow();
            booksForm.Show();
        }

        private void readersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form readersForm = new ReadersWindow();
            readersForm.Show();
        }

        private void issuanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form issuancesForm = new IssuancesWindow();
            issuancesForm.Show();
        }

        private void booksToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form issuancesForm = new ViewByBooks();
            issuancesForm.Show();
        }

        private void readersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form issuancesForm = new IssuanceByReader();
            issuancesForm.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
