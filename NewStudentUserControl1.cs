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
    public partial class NewStudentUserControl1 : UserControl
    {
        private Panel homePagePanel;

        private Button menuBtn;
        public NewStudentUserControl1(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            cancelBtn.Click += handleCancelBtn;

            newStudentBtn.Click += handleNewStudentBtn;
        }

        private void handleCancelBtn(object sender, EventArgs e)
        {
            menuBtn.Visible = false;
            
            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new MenuUserControl(homePagePanel, menuBtn));
        }
        private void handleNewStudentBtn(object sender, EventArgs e)
        {
            StringBuilder output = new StringBuilder();

            //

            menuBtn.Visible = false;

            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new MenuUserControl(homePagePanel, menuBtn));

        }
    }
}
