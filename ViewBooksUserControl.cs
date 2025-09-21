using LibraryBookSystem.ist2jyDataSetTableAdapters;
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
    public partial class ViewBooksUserControl : UserControl
    {
        public ViewBooksUserControl()
        {
            InitializeComponent();

            String[] bookCategory = { "Scince", "Mathematics", "Friction" };

            for (int i = 0; i < bookCategory.Length; i++)
            {
                bookCategoryComboBox.Items.Add(bookCategory[i]);
            }

            bookCategoryComboBox.SelectedIndex = 0;
        }
    }
}
