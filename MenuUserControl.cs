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
    public partial class MenuUserControl : UserControl 

    {
        private Panel homePagePanel;

        private Button menuBtn;
        public MenuUserControl(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;   

            bookingBtn.Click += handleBookingBtn;

            CreateNewStudentBtn.Click += handleCreateNewStudent;

            availableBooksBtn.Click += handleAvailableBooksBtn;

            viewBookingsBtn.Click += handleViewBookingsBtn;

            returnedBookBtn.Click += handleReturnedBookBtn;
        }
        private void switchUserControl(UserControl userControl)
        {
            menuBtn.Visible = true;

            homePagePanel.Controls.Clear();

            //homePagePanel.Dock = DockStyle.Fill;

            homePagePanel.Controls.Add(userControl);
        }
        private void handleBookingBtn(object sender, EventArgs e)
        {
            switchUserControl(new bookingsUserControl(homePagePanel, menuBtn));
        }

        private void handleCreateNewStudent(object sender, EventArgs e)
        { 
            switchUserControl(new NewStudentUserControl1(homePagePanel, menuBtn));
        }

        private void handleAvailableBooksBtn(object sender, EventArgs e)
        {
            switchUserControl(new ViewBooksUserControl());
        }

        private void handleViewBookingsBtn(object sender, EventArgs e)
        {
            // switch component
        }

        private void handleReturnedBookBtn(object sender, EventArgs e)
        {
            // switch component
        }

        private void MenuUserControl_Load(object sender, EventArgs e)
        {

        }

        private void availableBooksBtn_Click(object sender, EventArgs e)
        {

        }

        private void bookingBtn_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewStudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewBookingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void returnedBookBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewBorrowHistBtn_Click(object sender, EventArgs e)
        {

        }
    }
}