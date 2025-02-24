using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftWareProject
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username = '" + txtUsername.Text + "' and pass ='" + txtPassword.Text + "'";
            DataSet ds = fn.GetData(query);

            

            if (ds.Tables[0].Rows.Count != 0 )
            {
                labelError.Visible = false;
                DashBoard dashB = new DashBoard();
                this.Hide();
                dashB.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }

          
         

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
               Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
