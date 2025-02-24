using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftWareProject.User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;

        public UC_Employee()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }


        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }


        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtEmail.Text != "" && txtGender.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
            {
                string name = txtName.Text;
                int moblie = int.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string username = txtUserName.Text;
                string pass = txtPassword.Text;
                string email = txtEmail.Text;

                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('" + name + "'," + moblie + ",'" + gender + "','" + email + "','" + username + "','" + pass + "' )";
                fn.setData(query,"Employee registration successfully!");

                clearAll();
                getMaxID();

            }


        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);

            }else if(tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Confirm information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid =" + txtID.Text + "";
                    fn.setData(query, "Employee information was deleted");
                    tabEmployee_SelectedIndexChanged(this, null);

                }
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
