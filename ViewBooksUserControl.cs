using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryBookSystem
{
    public partial class ViewBooksUserControl : UserControl
    {
        string connectionString = "Data Source=143.128.146.30\\istn2;Initial Catalog=ist2ko;Persist Security Info=True;User ID=ist2ko;Password=jioeox;Encrypt=True;TrustServerCertificate=True";

        public ViewBooksUserControl(Panel homePagePanel, Button menuBtn)
        {
            InitializeComponent();

            getCategories();

        }
        private void getCategories()
        {
            String query = "SELECT DISTINCT Book_Category FROM Book";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bookCategoryComboBox.Items.Add(reader["Book_Category"].ToString());
                    }
                }
            }
        }

        private void ViewBooksUserControl_Load(object sender, EventArgs e)
        {

        }

        private void bookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ist2koDataSet);

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy2(this.ist2koDataSet.Book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
