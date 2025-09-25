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
    public partial class ReservationUserControl1 : UserControl
    {
        Button viewReservationBtn;
        public ReservationUserControl1(Panel homePagePanel, Button menuBtn, Button viewReservationBtn)
        {
            InitializeComponent();

            this.viewReservationBtn = viewReservationBtn;
        }

        private void reservationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2koDataSet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.reservationTableAdapter.FillBy(this.ist2koDataSet.Reservation);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
