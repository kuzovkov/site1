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
    public partial class ReadersWindow : Form
    {
        public ReadersWindow()
        {
            InitializeComponent();
        }

        private void readersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.readersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDBDataSet);

        }

        private void ReadersWindow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDBDataSet.Readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter.Fill(this.libraryDBDataSet.Readers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
