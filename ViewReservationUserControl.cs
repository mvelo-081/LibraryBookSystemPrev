using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class ViewReservationUserControl : UserControl
    {
        string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ko;Persist Security Info=True;User ID=ist2ko;Password=jioeox;Encrypt=True;TrustServerCertificate=True";

        Panel homePagePanel;

        Button menuBtn;

        Button ViewReservationBtn;
        public ViewReservationUserControl(Panel homePagePanel, Button menuBtn, Button ViewReservationBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            this.ViewReservationBtn = ViewReservationBtn;

            CancelBtn.Click += handleCancelBtn;

            bookingSubmitBtn.Click += handleBookingSubmitBtn;

            studentEmailData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studentEmailData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            studentEmailData.AutoCompleteCustomSource = GetStudentEmails();

            bookTitleData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookTitleData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookTitleData.AutoCompleteCustomSource = GetBookTitles();

            studentEmailData.TextChanged += new EventHandler(fillStudentNamesAndSurname);
        }
        private AutoCompleteStringCollection GetBookTitles()
        {
            AutoCompleteStringCollection bookTitles = new AutoCompleteStringCollection();

            string query = "SELECT Book_Title FROM Book";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bookTitles.Add(reader["Book_Title"].ToString());
                    }
                }
            }

            return bookTitles;
        }

        private AutoCompleteStringCollection GetStudentEmails()
        {
            ErrorLabel.Visible = false;

            AutoCompleteStringCollection studentEmails = new AutoCompleteStringCollection();

            string query = "SELECT Student_Email FROM Student";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        studentEmails.Add(reader["Student_Email"].ToString());
                    }
                }
            }

            return studentEmails;
        }
        private void fillStudentNamesAndSurname(object sender, EventArgs e)
        {
            string query = "SELECT Student_FName, Student_LName FROM Student WHERE Student_Email = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", studentEmailData.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        studentnameSurnameTextData.Text = reader["Student_FName"].ToString() + " " + reader["Student_LName"].ToString();
                    }
                }
            }
        }


        private void handleCancelBtn(object sender, EventArgs e)
        {
            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new ReservationUserControl1(homePagePanel, menuBtn, ViewReservationBtn));

            ViewReservationBtn.Visible = true;

            ViewReservationBtn.Text = "Add Reservation";
        }

        private void handleBookingSubmitBtn(object sender, EventArgs e)
        {
            String query = "";
        }
    }
}
