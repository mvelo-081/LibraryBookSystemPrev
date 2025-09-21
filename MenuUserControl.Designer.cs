namespace LibraryBookSystem
{
    partial class MenuUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewBorrowHistBtn = new System.Windows.Forms.Button();
            this.returnedBookBtn = new System.Windows.Forms.Button();
            this.viewBookingsBtn = new System.Windows.Forms.Button();
            this.bookingBtn = new System.Windows.Forms.Button();
            this.availableBooksBtn = new System.Windows.Forms.Button();
            this.CreateNewStudentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewBorrowHistBtn
            // 
            this.viewBorrowHistBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBorrowHistBtn.Location = new System.Drawing.Point(591, 310);
            this.viewBorrowHistBtn.Name = "viewBorrowHistBtn";
            this.viewBorrowHistBtn.Size = new System.Drawing.Size(177, 153);
            this.viewBorrowHistBtn.TabIndex = 11;
            this.viewBorrowHistBtn.Text = "View Borrow History";
            this.viewBorrowHistBtn.UseVisualStyleBackColor = true;
            this.viewBorrowHistBtn.Click += new System.EventHandler(this.viewBorrowHistBtn_Click);
            // 
            // returnedBookBtn
            // 
            this.returnedBookBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnedBookBtn.Location = new System.Drawing.Point(324, 310);
            this.returnedBookBtn.Name = "returnedBookBtn";
            this.returnedBookBtn.Size = new System.Drawing.Size(177, 153);
            this.returnedBookBtn.TabIndex = 10;
            this.returnedBookBtn.Text = "Return A Book";
            this.returnedBookBtn.UseVisualStyleBackColor = true;
            this.returnedBookBtn.Click += new System.EventHandler(this.returnedBookBtn_Click);
            // 
            // viewBookingsBtn
            // 
            this.viewBookingsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBookingsBtn.Location = new System.Drawing.Point(42, 310);
            this.viewBookingsBtn.Name = "viewBookingsBtn";
            this.viewBookingsBtn.Size = new System.Drawing.Size(177, 153);
            this.viewBookingsBtn.TabIndex = 9;
            this.viewBookingsBtn.Text = "View Bookings";
            this.viewBookingsBtn.UseVisualStyleBackColor = true;
            this.viewBookingsBtn.Click += new System.EventHandler(this.viewBookingsBtn_Click);
            // 
            // bookingBtn
            // 
            this.bookingBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingBtn.Location = new System.Drawing.Point(591, 47);
            this.bookingBtn.Name = "bookingBtn";
            this.bookingBtn.Size = new System.Drawing.Size(177, 153);
            this.bookingBtn.TabIndex = 8;
            this.bookingBtn.Text = "Add A Booking";
            this.bookingBtn.UseVisualStyleBackColor = true;
            this.bookingBtn.Click += new System.EventHandler(this.bookingBtn_Click);
            // 
            // availableBooksBtn
            // 
            this.availableBooksBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableBooksBtn.Location = new System.Drawing.Point(324, 47);
            this.availableBooksBtn.Name = "availableBooksBtn";
            this.availableBooksBtn.Size = new System.Drawing.Size(177, 153);
            this.availableBooksBtn.TabIndex = 7;
            this.availableBooksBtn.Text = "View Available Books";
            this.availableBooksBtn.UseVisualStyleBackColor = true;
            this.availableBooksBtn.Click += new System.EventHandler(this.availableBooksBtn_Click);
            // 
            // CreateNewStudentBtn
            // 
            this.CreateNewStudentBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewStudentBtn.Location = new System.Drawing.Point(42, 47);
            this.CreateNewStudentBtn.Name = "CreateNewStudentBtn";
            this.CreateNewStudentBtn.Size = new System.Drawing.Size(177, 153);
            this.CreateNewStudentBtn.TabIndex = 6;
            this.CreateNewStudentBtn.Text = "New Student";
            this.CreateNewStudentBtn.UseVisualStyleBackColor = true;
            this.CreateNewStudentBtn.Click += new System.EventHandler(this.CreateNewStudentBtn_Click);
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewBorrowHistBtn);
            this.Controls.Add(this.returnedBookBtn);
            this.Controls.Add(this.viewBookingsBtn);
            this.Controls.Add(this.bookingBtn);
            this.Controls.Add(this.availableBooksBtn);
            this.Controls.Add(this.CreateNewStudentBtn);
            this.MaximumSize = new System.Drawing.Size(810, 510);
            this.MinimumSize = new System.Drawing.Size(810, 510);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(810, 510);
            this.Load += new System.EventHandler(this.MenuUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewBorrowHistBtn;
        private System.Windows.Forms.Button returnedBookBtn;
        private System.Windows.Forms.Button viewBookingsBtn;
        private System.Windows.Forms.Button bookingBtn;
        private System.Windows.Forms.Button availableBooksBtn;
        private System.Windows.Forms.Button CreateNewStudentBtn;
    }
}
