using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleContactForm
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }
        contexClass c = new contexClass();
        private void Contact_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            ContactdataGridView.DataSource = dt;
        }
        public void Clear()
        {
            txtboxFname.Text = "";
            txtboxLname.Text = "";
            txtboxAddress.Text = "";
            txtboxContactNo.Text = "";
            comboBox1.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the value from the input fields
            c.Fname = txtboxFname.Text;
            c.Lname = txtboxLname.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = comboBox1.Text;

            bool success = c.Insert(c);

            if(success==true)
            {
                MessageBox.Show("New Contact Seccessfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add New Contact.Try Again.");
            }
            DataTable dt = c.Select();
            ContactdataGridView.DataSource = dt;
        }

        private void ContactdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
