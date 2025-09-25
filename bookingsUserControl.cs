using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryBookSystem
{
    public partial class bookingsUserControl : UserControl
    {
        string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ko;Persist Security Info=True;User ID=ist2ko;Password=jioeox;Encrypt=True;TrustServerCertificate=True";

        private Panel homePagePanel;

        private Button menuBtn;

        private Button ViewReservationBtn;
        public bookingsUserControl(Panel homePagePanel, Button menuBtn, Button ViewReservationBtn)
        {
            InitializeComponent();

            this.homePagePanel = homePagePanel;

            this.menuBtn = menuBtn;

            this.ViewReservationBtn = ViewReservationBtn;

            bookingSubmitBtn.Click += HandleSubmitBookingBtn;

            CancelBookingBtn.Click += HandleCancelBookingBtn;

            bookTitleData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            bookTitleData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            bookTitleData.AutoCompleteCustomSource = GetBookTitles();

            studentEmailData.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            studentEmailData.AutoCompleteSource = AutoCompleteSource.CustomSource;
            studentEmailData.AutoCompleteCustomSource = GetStudentEmails();

            studentnameSurnameTextData.Text = "";
            studentEmailData.TextChanged += new EventHandler(fillStudentNamesAndSurname);

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
        private AutoCompleteStringCollection GetStudentEmails() 
        {
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

        private String getBookId()
        {
            String bookTitle = bookTitleData.Text;

            using (SqlConnection connection = new SqlConnection(connectionString)) 
            { 
                connection.Open();

                String query = "SELECT BookID FROM Book WHERE Book_Title = @BookTitle";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookTitle", bookTitle);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["BookID"].ToString();
                        }
                        {
                            return "";
                        }
                    }
                }
            }
        }
        private String getStudentId()
        {
            String studentName = studentnameSurnameTextData.Text;
            String studentEmail = studentEmailData.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                String query = "SELECT StudentID FROM Student WHERE Student_FName = @StudentName AND Student_Email = @studentEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentName", studentName);
                    command.Parameters.AddWithValue("@studentEmail", studentEmail);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["StudentID"].ToString();
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }
        }
        private void HandleSubmitBookingBtn(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentnameSurnameTextData.Text) ||
                string.IsNullOrWhiteSpace(bookTitleData.Text) ||
                string.IsNullOrWhiteSpace(returnDateData.Text))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = ("Please fill in all fields.");
                return;
            }

            string studentID = getStudentId();
            string bookID = getBookId();

            if (string.IsNullOrEmpty(studentID) || string.IsNullOrEmpty(bookID))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Student or Book not found in the system.";
                return;
            }

            if (!DateTime.TryParse(returnDateData.Text, out DateTime returnDate))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Invalid return date.";
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = @"
                SELECT 
                    (SELECT COUNT(*) FROM Borrow WHERE BookID = @BookID) AS BorrowedCount,
                    (SELECT book_quantity FROM Books WHERE BookID = @BookID) AS TotalQuantity";

                    int borrowedCount = 0;
                    int totalQuantity = 0;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@BookID", bookID);
                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                borrowedCount = reader["BorrowedCount"] != DBNull.Value ? Convert.ToInt32(reader["BorrowedCount"]) : 0;
                                totalQuantity = reader["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(reader["TotalQuantity"]) : 0;
                            }
                        }
                    }

                    if (borrowedCount >= totalQuantity)
                    {
                        ErrorLabel.ForeColor = Color.Red;
                        ErrorLabel.Text = "This book is currently unavailable (all copies borrowed).";

                        homePagePanel.Controls.Clear();
                        ViewReservationUserControl viewReservation = new ViewReservationUserControl(homePagePanel, menuBtn, ViewReservationBtn);
                        homePagePanel.Controls.Add(viewReservation);

                        return;
                    }

                    string insertQuery = @"
                INSERT INTO Borrow (StudentID, BookID, Return_Date)
                OUTPUT INSERTED.BorrowID
                VALUES (@StudentID, @BookID, @ReturnDate)";

                    int newBorrowId = 0;
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@StudentID", studentID);
                        insertCmd.Parameters.AddWithValue("@BookID", bookID);
                        insertCmd.Parameters.AddWithValue("@ReturnDate", returnDate);

                        newBorrowId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    if (newBorrowId > 0)
                    {
                        ErrorLabel.ForeColor = Color.Green;
                        ErrorLabel.Text = $"The {studentnameSurnameTextData.Text} has successfully borrowed the book: {bookTitleData.Text}";
                    }
                    else
                    {
                        ErrorLabel.ForeColor = Color.Red;
                        ErrorLabel.Text = "Failed to borrow book. Please try again.";
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = $"Error: {ex.Message}";
            }
        }



        private void HandleCancelBookingBtn(object sender, EventArgs e)
        {
            menuBtn.Visible = false;

            homePagePanel.Controls.Clear();

            homePagePanel.Controls.Add(new MenuUserControl(homePagePanel, menuBtn));
        }
    }
}
