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
    public partial class IssuancesWindow : Form
    {
        public IssuancesWindow()
        {
            InitializeComponent();
        }

        private void issuanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.issuanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDBDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Issuance". При необходимости она может быть перемещена или удалена.
            this.issuanceTableAdapter.Fill(this.libraryDBDataSet.Issuance);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter.Fill(this.libraryDBDataSet.Readers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDBDataSet.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Issuance". При необходимости она может быть перемещена или удалена.
            this.issuanceTableAdapter.Fill(this.libraryDBDataSet.Issuance);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.booksTableAdapter.FillBy(this.libraryDBDataSet.Books);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.readersTableAdapter.FillBy(this.libraryDBDataSet.Readers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.issuanceTableAdapter.FillBy(this.libraryDBDataSet.Issuance);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void issuanceBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.issuanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDBDataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
