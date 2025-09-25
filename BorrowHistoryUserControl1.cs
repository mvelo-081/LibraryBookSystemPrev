using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class BorrowHistoryUserControl1 : UserControl
    {
        public BorrowHistoryUserControl1(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();
        }

        private void borrowBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.borrowBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2koDataSet);

        }

        private void borrowDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.borrowTableAdapter.FillBy(this.ist2koDataSet.Borrow);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
