﻿using System;
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
    public partial class LandingPage : Form
    {
        private Boolean isMananger = false;

        private Boolean isTestingMode = false; // change this if not in testing mode!
        public LandingPage()
        {
            InitializeComponent();

            // Adding event Handles for buttons

            toggleAdminRoleBtn.Click += handleToggleRoleBtn;

            signInBtn.Click += handleSignin;
        }

        // toggle between manager and librarian roles
        private void handleToggleRoleBtn(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
            if (isMananger)
            {
                toggleAdminRoleBtn.Text = "Manager Profile".ToString();
                roleLabel.Text = "Enter Librarian Username:".ToString();
                welcomeLabel.Text = "Welcome back, Librarian!".ToString();
                subWelcomeLabel.Text = "Manage books, members, and library operations with ease".ToString();
            }
            else
            { 
                toggleAdminRoleBtn.Text = "Librarian Profile".ToString();
                roleLabel.Text = "Enter Manager Username:".ToString();
                welcomeLabel.Text = "Welcome back, Manager!".ToString();
                subWelcomeLabel.Text = "Access reports, staff management, and library operations from your dashboard.".ToString();
            }
            // toggles roles
            isMananger = !isMananger;
        }

        // handles sign in button click
        private void handleSignin(object sender, EventArgs e)
        {
            if (isTestingMode )
            {
                LandingPageMainPanel.Controls.Clear();
                LandingPageMainPanel.Dock = DockStyle.Fill;
                LibrarianHomePage homePage = new LibrarianHomePage();
                LandingPageMainPanel.Controls.Add(homePage);
                return;
            }
            string password = UserPasswordTextData.Text;
            string username = UserIdTextData.Text;

            string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ko;Persist Security Info=True;User ID=ist2ko;Password=jioeox;Encrypt=True;TrustServerCertificate=True";

            string query = "SELECT Staff_username, Staff_Password, Staff_Role FROM Staff WHERE Staff_Password = @Password AND Staff_username = @Username";


            using (SqlConnection sqlconnect = new SqlConnection(connectionString))
            {
                sqlconnect.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, sqlconnect))
                {
                    sqlCommand.Parameters.AddWithValue("@Password", password);
                    sqlCommand.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            string role = reader["Staff_Role"].ToString();

                            if (role == "Manager" && isMananger)
                            {
                                LandingPageMainPanel.Controls.Clear();
                                LandingPageMainPanel.Dock = DockStyle.Fill;
                                ManagerHomePage homePage = new ManagerHomePage();
                                LandingPageMainPanel.Controls.Add(homePage);
                            }
                            else if (role == "Librarian" && !isMananger)
                            {
                                LandingPageMainPanel.Controls.Clear();
                                LandingPageMainPanel.Dock = DockStyle.Fill;
                                LibrarianHomePage homePage = new LibrarianHomePage();
                                LandingPageMainPanel.Controls.Add(homePage);
                            }
                            else if (role == "Manager" && !isMananger)
                            {
                                ErrorLabel.Text = "Please switch to Manager role to sign in.";
                                toggleAdminRoleBtn.Focus();
                                toggleAdminRoleBtn.BackColor = Color.LightBlue;
                                ErrorLabel.Visible = true;
                            }
                            else if (role == "Librarian" && isMananger)
                            {
                                ErrorLabel.Text = "Please switch to Librarian role to sign in.";
                                toggleAdminRoleBtn.Focus();
                                toggleAdminRoleBtn.BackColor = Color.LightBlue;
                                ErrorLabel.Visible = true;
                            }
                            else if (role != "Manager" && role != "Librarian")
                            {
                                ErrorLabel.Text = "Unknown role for this user.";
                                ErrorLabel.Visible = true;
                            }
                        }
                        else
                        {
                            ErrorLabel.Text = "Invalid credentials, please try again.";
                            ErrorLabel.Visible = true;
                        }
                    }
                }
            }
        }



        private void IconImgPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
