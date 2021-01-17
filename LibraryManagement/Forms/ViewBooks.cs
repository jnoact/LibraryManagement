﻿using LibraryManagement.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.Forms
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads data into the data grid view. 
        /// Changes the background color of the checkedout cell if the book is checkedout or not. 
        /// Bolds the text of the checkout cell. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBooks_Load(object sender, EventArgs e)
        {
            BookHelper.CurrentBooksData(dgvViewBooks); 
            foreach(DataGridViewRow row in dgvViewBooks.Rows)
            {
                if (row.Cells["Checkedout"].Value.ToString() == "NO")
                {
                    row.Cells["Checkedout"].Style.BackColor = Color.FromArgb(184, 244, 191);
                    row.Cells["Checkedout"].Style.Font = new Font(dgvViewBooks.Font, FontStyle.Bold);
                }
                else
                {
                    row.Cells["Checkedout"].Style.BackColor = Color.Salmon;
                    row.Cells["Checkedout"].Style.Font = new Font(dgvViewBooks.Font, FontStyle.Bold);
                }
            }
        }
    }
}
