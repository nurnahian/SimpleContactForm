using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            txtboxCustomarId.Text = "";
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
            int rowIndex = e.RowIndex;

            txtboxCustomarId.Text = ContactdataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            txtboxFname.Text = ContactdataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            txtboxLname.Text = ContactdataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            txtboxContactNo.Text = ContactdataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            txtboxAddress.Text = ContactdataGridView.Rows[rowIndex].Cells[4].Value.ToString();
            comboBox1.Text = ContactdataGridView.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            c.CustomarId = int.Parse(txtboxCustomarId.Text);
            c.Fname = txtboxFname.Text;
            c.Lname = txtboxLname.Text;
            c.ContactNo = txtboxContactNo.Text;
            c.Address = txtboxAddress.Text;
            c.Gender = comboBox1.Text;

            bool success = c.Update(c);

            if (success == true)
            {
                MessageBox.Show("Contact has been successfully Updated.");

                DataTable dt = c.Select();
                ContactdataGridView.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update contact.Try Again.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            c.CustomarId = Convert.ToInt32(txtboxCustomarId.Text);

            bool success = c.Delete(c);

            if (success == true)
            {
                MessageBox.Show("Contact Successfully Deleted.");
                DataTable dt = c.Select();
                ContactdataGridView.DataSource = dt;
                Clear();
            }
            else
            {
                MessageBox.Show("Faild to Delete Contact.Try Again.");
            }
        }
        static string mycoonstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtboxSearch.Text;

            SqlConnection conn = new SqlConnection(mycoonstr);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Contact WHERE Fname Like '%" + keyword + "%' OR Lname Like '%"+keyword+"%' OR Address Like '%"+keyword+ "%' OR ContactNo Like '%"+keyword+"%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ContactdataGridView.DataSource = dt;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
