using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using DotNetShipping.ShippingProviders;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DotNetShipping.SampleApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            radio_n.Checked = true;
        }


        private void submit_but_Click(object sender, EventArgs e)
        {
            Program.readParts = new string[10, 2];

            if (zip_box.Text != "")
            {
                Program.zipcode = zip_box.Text;
                if (radio_y.Checked) { Program.res = true; } else { Program.res = false; }

                for (int i = 0; i < parts.RowCount; i++)
                {

                    DataGridViewRow row = parts.Rows[i];

                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        Program.readParts[i, 0] = row.Cells[0].Value.ToString();
                        Program.readParts[i, 1] = row.Cells[1].Value.ToString();
                    }
                }

                Program.Begin();
            }
            else
            {
                MessageBox.Show("Please enter a valid zipcode.");
            }
        }

        private void reset_but_Click(object sender, EventArgs e)
        {
            parts.DataSource = null;
            parts.Rows.Clear();
            zip_box.Clear();
            radio_y.Checked = false;
            radio_n.Checked = true;
        }
    }
}
