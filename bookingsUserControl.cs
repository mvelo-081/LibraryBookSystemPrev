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
    public partial class bookingsUserControl : UserControl
    {

        private Panel homePagePanel;

        private Button menuBtn;
        public bookingsUserControl(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn; 

            bookingSubmitBtn.Click += bookingSubmitBtn_Click;

            CancelBookingBtn.Click += HandleCancelBookingBtn;
        }

        private void bookingSubmitBtn_Click(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();

            output.Append("\tBooking Successfull!\n");
            output.AppendLine("\nBy a student : " + nameSurnameTextData.Text);
            output.AppendLine("\nBook name : " + bookTitleData.Text);
            output.AppendLine("\nReturn date : " + returnDateData.Text);

            MessageBox.Show(output.ToString());

        }

        private void HandleCancelBookingBtn(object sender, EventArgs e)
        {
            menuBtn.Visible = false;

            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new MenuUserControl(homePagePanel, menuBtn));
        }
    }
}
