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
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        string query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
         
           
            query = "select customer.cid, customer.cname, customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin, rooms.roomNumber,rooms.roomType,rooms.bed, rooms.prices from customer inner join rooms on customer.roomid = rooms.roomID where chekout = 'NO' ";
            DataSet ds = fn.GetData(query); 
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin, rooms.roomNumber,rooms.roomType,rooms.bed, rooms.prices from customer inner join rooms on customer.roomid = rooms.roomID where cname like '" + txtName.Text + "%' and chekout = 'NO'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }
        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtShowName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtShowName.Text != "")
            {
                if (MessageBox.Show("Confirm payment ?\nCustomer data will be deleted !", "Confirmation", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
                {
                    string cdate = txtCheckOutDate.Text;
                    query = "update customer set chekout = 'YES', checkout = '" + cdate + "' where cid = " + id + ";update rooms set booked = 'NO' where roomNumber = '" + txtRoom.Text + "'";


                    fn.setData(query, "Payment succesfully!");
                    UC_CheckOut_Load(this, null);
                   
                    clearAll();


                }
            }

            else
            {
                MessageBox.Show("Customer information does not exist or customer information has not been selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void clearAll()
        {
            txtShowName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
