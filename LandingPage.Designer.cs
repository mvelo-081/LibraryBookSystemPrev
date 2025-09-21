namespace LibraryBookSystem
{
    partial class LandingPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.LandingPageMainPanel = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.toggleAdminRoleBtn = new System.Windows.Forms.Button();
            this.IconLabel = new System.Windows.Forms.Label();
            this.IconImgPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.signInBtn = new System.Windows.Forms.Button();
            this.UserPasswordTextData = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.UserIdTextData = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.LandingPageMainPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LandingPageMainPanel
            // 
            this.LandingPageMainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LandingPageMainPanel.Controls.Add(this.navPanel);
            this.LandingPageMainPanel.Controls.Add(this.label1);
            this.LandingPageMainPanel.Controls.Add(this.signInBtn);
            this.LandingPageMainPanel.Controls.Add(this.UserPasswordTextData);
            this.LandingPageMainPanel.Controls.Add(this.passwordLabel);
            this.LandingPageMainPanel.Controls.Add(this.UserIdTextData);
            this.LandingPageMainPanel.Controls.Add(this.roleLabel);
            this.LandingPageMainPanel.Controls.Add(this.welcomeLabel);
            this.LandingPageMainPanel.Location = new System.Drawing.Point(1, 1);
            this.LandingPageMainPanel.Name = "LandingPageMainPanel";
            this.LandingPageMainPanel.Size = new System.Drawing.Size(1173, 661);
            this.LandingPageMainPanel.TabIndex = 8;
            // 
            // navPanel
            // 
            this.navPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navPanel.Controls.Add(this.toggleAdminRoleBtn);
            this.navPanel.Controls.Add(this.IconLabel);
            this.navPanel.Controls.Add(this.IconImgPanel);
            this.navPanel.Location = new System.Drawing.Point(12, 12);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(1148, 62);
            this.navPanel.TabIndex = 22;
            // 
            // toggleAdminRoleBtn
            // 
            this.toggleAdminRoleBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleAdminRoleBtn.Location = new System.Drawing.Point(979, 13);
            this.toggleAdminRoleBtn.Name = "toggleAdminRoleBtn";
            this.toggleAdminRoleBtn.Size = new System.Drawing.Size(155, 35);
            this.toggleAdminRoleBtn.TabIndex = 1;
            this.toggleAdminRoleBtn.Text = "Manager profile";
            this.toggleAdminRoleBtn.UseVisualStyleBackColor = true;
            // 
            // IconLabel
            // 
            this.IconLabel.AutoSize = true;
            this.IconLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconLabel.Location = new System.Drawing.Point(83, 13);
            this.IconLabel.Name = "IconLabel";
            this.IconLabel.Size = new System.Drawing.Size(245, 35);
            this.IconLabel.TabIndex = 1;
            this.IconLabel.Text = "Library book system";
            // 
            // IconImgPanel
            // 
            this.IconImgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconImgPanel.BackgroundImage")));
            this.IconImgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconImgPanel.Location = new System.Drawing.Point(12, 3);
            this.IconImgPanel.Name = "IconImgPanel";
            this.IconImgPanel.Size = new System.Drawing.Size(65, 54);
            this.IconImgPanel.TabIndex = 0;
            this.IconImgPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.IconImgPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Manage books, members, and library operations with ease";
            // 
            // signInBtn
            // 
            this.signInBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.Location = new System.Drawing.Point(385, 456);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(187, 42);
            this.signInBtn.TabIndex = 20;
            this.signInBtn.Text = "Sign in";
            this.signInBtn.UseVisualStyleBackColor = true;
            // 
            // UserPasswordTextData
            // 
            this.UserPasswordTextData.BackColor = System.Drawing.SystemColors.Control;
            this.UserPasswordTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPasswordTextData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordTextData.Location = new System.Drawing.Point(385, 391);
            this.UserPasswordTextData.Name = "UserPasswordTextData";
            this.UserPasswordTextData.Size = new System.Drawing.Size(276, 30);
            this.UserPasswordTextData.TabIndex = 19;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(381, 345);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(130, 23);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Enter password:";
            // 
            // UserIdTextData
            // 
            this.UserIdTextData.BackColor = System.Drawing.SystemColors.Control;
            this.UserIdTextData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserIdTextData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdTextData.Location = new System.Drawing.Point(385, 295);
            this.UserIdTextData.Name = "UserIdTextData";
            this.UserIdTextData.Size = new System.Drawing.Size(276, 30);
            this.UserIdTextData.TabIndex = 17;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(381, 249);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(145, 23);
            this.roleLabel.TabIndex = 16;
            this.roleLabel.Text = "Enter Librarian Id:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(437, 163);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(349, 38);
            this.welcomeLabel.TabIndex = 15;
            this.welcomeLabel.Text = "Welcome back, Librarian!";
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 658);
            this.Controls.Add(this.LandingPageMainPanel);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1190, 705);
            this.MinimumSize = new System.Drawing.Size(1190, 705);
            this.Name = "LandingPage";
            this.Text = "Sign in";
            this.LandingPageMainPanel.ResumeLayout(false);
            this.LandingPageMainPanel.PerformLayout();
            this.navPanel.ResumeLayout(false);
            this.navPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LandingPageMainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.TextBox UserPasswordTextData;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox UserIdTextData;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button toggleAdminRoleBtn;
        private System.Windows.Forms.Label IconLabel;
        private System.Windows.Forms.Panel IconImgPanel;
    }
}

