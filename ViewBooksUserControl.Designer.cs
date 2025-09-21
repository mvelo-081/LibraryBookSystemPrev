namespace LibraryBookSystem
{
    partial class ViewBooksUserControl
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameData = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.bookCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.custNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERPRAC3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ist2jyDataSet = new LibraryBookSystem.ist2jyDataSet();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cUSTOMERPRAC3TableAdapter = new LibraryBookSystem.ist2jyDataSetTableAdapters.CUSTOMERPRAC3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERPRAC3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book inventory";
            // 
            // studentNameData
            // 
            this.studentNameData.BackColor = System.Drawing.SystemColors.Control;
            this.studentNameData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentNameData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameData.Location = new System.Drawing.Point(122, 78);
            this.studentNameData.Name = "studentNameData";
            this.studentNameData.Size = new System.Drawing.Size(522, 30);
            this.studentNameData.TabIndex = 18;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(14, 80);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(102, 23);
            this.roleLabel.TabIndex = 17;
            this.roleLabel.Text = "Enter name:";
            // 
            // bookCategoryComboBox
            // 
            this.bookCategoryComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.bookCategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCategoryComboBox.FormattingEnabled = true;
            this.bookCategoryComboBox.Location = new System.Drawing.Point(663, 78);
            this.bookCategoryComboBox.Name = "bookCategoryComboBox";
            this.bookCategoryComboBox.Size = new System.Drawing.Size(121, 31);
            this.bookCategoryComboBox.TabIndex = 19;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custNoDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.cUSTOMERPRAC3BindingSource;
            this.dataGrid.Location = new System.Drawing.Point(122, 134);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(662, 331);
            this.dataGrid.TabIndex = 20;
            // 
            // custNoDataGridViewTextBoxColumn
            // 
            this.custNoDataGridViewTextBoxColumn.DataPropertyName = "CustNo";
            this.custNoDataGridViewTextBoxColumn.HeaderText = "CustNo";
            this.custNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custNoDataGridViewTextBoxColumn.Name = "custNoDataGridViewTextBoxColumn";
            this.custNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERPRAC3BindingSource
            // 
            this.cUSTOMERPRAC3BindingSource.DataMember = "CUSTOMERPRAC3";
            this.cUSTOMERPRAC3BindingSource.DataSource = this.ist2jyDataSet;
            // 
            // ist2jyDataSet
            // 
            this.ist2jyDataSet.DataSetName = "ist2jyDataSet";
            this.ist2jyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // cUSTOMERPRAC3TableAdapter
            // 
            this.cUSTOMERPRAC3TableAdapter.ClearBeforeFill = true;
            // 
            // ViewBooksUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.bookCategoryComboBox);
            this.Controls.Add(this.studentNameData);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(810, 510);
            this.MinimumSize = new System.Drawing.Size(810, 510);
            this.Name = "ViewBooksUserControl";
            this.Size = new System.Drawing.Size(810, 510);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERPRAC3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ist2jyDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentNameData;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox bookCategoryComboBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cUSTOMERPRAC3BindingSource;
        private ist2jyDataSet ist2jyDataSet;
        private ist2jyDataSetTableAdapters.CUSTOMERPRAC3TableAdapter cUSTOMERPRAC3TableAdapter;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}
