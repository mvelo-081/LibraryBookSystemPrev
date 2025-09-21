namespace LibraryBookSystem
{
    partial class bookingsUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookTitleData = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.studentIdData = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.bookingSubmitBtn = new System.Windows.Forms.Button();
            this.CancelBookingBtn = new System.Windows.Forms.Button();
            this.returnDateData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSurnameTextData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bookings";
            // 
            // bookTitleData
            // 
            this.bookTitleData.BackColor = System.Drawing.SystemColors.Control;
            this.bookTitleData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookTitleData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleData.Location = new System.Drawing.Point(246, 308);
            this.bookTitleData.Name = "bookTitleData";
            this.bookTitleData.Size = new System.Drawing.Size(276, 30);
            this.bookTitleData.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(242, 262);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(134, 23);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Enter Book Title:";
            // 
            // studentIdData
            // 
            this.studentIdData.BackColor = System.Drawing.SystemColors.Control;
            this.studentIdData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentIdData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdData.Location = new System.Drawing.Point(246, 108);
            this.studentIdData.Name = "studentIdData";
            this.studentIdData.Size = new System.Drawing.Size(276, 30);
            this.studentIdData.TabIndex = 7;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(242, 62);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(140, 23);
            this.roleLabel.TabIndex = 6;
            this.roleLabel.Text = "Enter Student ID:";
            // 
            // bookingSubmitBtn
            // 
            this.bookingSubmitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSubmitBtn.Location = new System.Drawing.Point(461, 452);
            this.bookingSubmitBtn.Name = "bookingSubmitBtn";
            this.bookingSubmitBtn.Size = new System.Drawing.Size(134, 35);
            this.bookingSubmitBtn.TabIndex = 15;
            this.bookingSubmitBtn.Text = "Submit";
            this.bookingSubmitBtn.UseVisualStyleBackColor = true;
            this.bookingSubmitBtn.Click += new System.EventHandler(this.bookingSubmitBtn_Click);
            // 
            // CancelBookingBtn
            // 
            this.CancelBookingBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBookingBtn.Location = new System.Drawing.Point(209, 452);
            this.CancelBookingBtn.Name = "CancelBookingBtn";
            this.CancelBookingBtn.Size = new System.Drawing.Size(155, 35);
            this.CancelBookingBtn.TabIndex = 14;
            this.CancelBookingBtn.Text = "Cancel";
            this.CancelBookingBtn.UseVisualStyleBackColor = true;
            // 
            // returnDateData
            // 
            this.returnDateData.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateData.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.returnDateData.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateData.Location = new System.Drawing.Point(246, 401);
            this.returnDateData.Name = "returnDateData";
            this.returnDateData.Size = new System.Drawing.Size(276, 25);
            this.returnDateData.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Return date:";
            // 
            // nameSurnameTextData
            // 
            this.nameSurnameTextData.BackColor = System.Drawing.SystemColors.Control;
            this.nameSurnameTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameSurnameTextData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSurnameTextData.Location = new System.Drawing.Point(246, 204);
            this.nameSurnameTextData.Name = "nameSurnameTextData";
            this.nameSurnameTextData.Size = new System.Drawing.Size(276, 30);
            this.nameSurnameTextData.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Enter Name and Surname:";
            // 
            // bookingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nameSurnameTextData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnDateData);
            this.Controls.Add(this.bookingSubmitBtn);
            this.Controls.Add(this.CancelBookingBtn);
            this.Controls.Add(this.bookTitleData);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.studentIdData);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(810, 510);
            this.MinimumSize = new System.Drawing.Size(810, 510);
            this.Name = "bookingsUserControl";
            this.Size = new System.Drawing.Size(810, 510);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookTitleData;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox studentIdData;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button bookingSubmitBtn;
        private System.Windows.Forms.Button CancelBookingBtn;
        private System.Windows.Forms.DateTimePicker returnDateData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameSurnameTextData;
        private System.Windows.Forms.Label label3;
    }
}
