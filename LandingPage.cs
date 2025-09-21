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
    public partial class LandingPage : Form
    {
        private Boolean isMananger = false;
        public LandingPage()
        {
            InitializeComponent();

            toggleAdminRoleBtn.Click += handleToggleRoleBtn;
            signInBtn.Click += handleSignin;
        }
 
        private void handleToggleRoleBtn(object sender, EventArgs e)
        {
            if (isMananger)
            {
                toggleAdminRoleBtn.Text = "Manager Profile".ToString();
                roleLabel.Text = "Enter Librarian ID:".ToString();
                welcomeLabel.Text = "Welcome back, Librarian!".ToString();
            }
            else
            { 
                toggleAdminRoleBtn.Text = "Librarian Profile".ToString();
                roleLabel.Text = "Enter Manager ID:".ToString();
                welcomeLabel.Text = "Welcome back, Manager!".ToString();
            }
            // toggles roles
            isMananger = !isMananger;
        }

        private void handleSignin(object sender, EventArgs e)
        {
            LandingPageMainPanel.Controls.Clear();

            LandingPageMainPanel.Dock = DockStyle.Fill;

                
            if (isMananger)
            {
                ManagerHomePage homePage = new ManagerHomePage();
                LandingPageMainPanel.Controls.Add(homePage);
            }
            else
            {
                LibrarianHomePage homePage = new LibrarianHomePage();
                LandingPageMainPanel.Controls.Add(homePage);
            }
        }

        private void IconImgPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
