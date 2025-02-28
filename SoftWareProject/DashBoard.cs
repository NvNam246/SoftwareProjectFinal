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
    public partial class DashBoard : Form
    {
        bool isOut = true;
        public DashBoard()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            uC_AddRoom1.Visible= false;
            uC_CustomerRegis1.Visible = true;
            uC_CustomerRegis1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();


        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            uC_CustomerDetail1.Visible = true;
            uC_CustomerDetail1.BringToFront();


        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible=false;
            uC_CustomerRegis1.Visible=false;
            uC_CheckOut1.Visible=false;
            uC_CustomerDetail1.Visible=false;
            uC_Employee1.Visible=false;
            btnAddRoom.PerformClick();

        }

        private void btnExitDashboard_Click(object sender, EventArgs e)
        {
            if(isOut)
            Application.Exit();
        }

        private void uC_AddRoom1_Load(object sender, EventArgs e)
        {

        }

        private void uC_CheckOut1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Do you want to logout?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                isOut = false;
                this.Close();
                Form1 form = new Form1();
                form.Show();
                
                 
            }
        }

        private void uC_Employee1_Load(object sender, EventArgs e)
        {

        }
    }
}
