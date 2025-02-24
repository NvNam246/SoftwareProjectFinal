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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            
            query = "select * from rooms";
            DataSet ds = fn.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(txtRoomNumber.Text != "" && txtRoomTypes.Text != "" && txtBed.Text != "" && txtPrices.Text != "")
            {
                string roomNo = txtRoomNumber.Text;
                string Type = txtRoomTypes.Text;
                string bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrices.Text);


                query = "insert into rooms (roomNumber,roomType,bed,prices) values ('" + roomNo + "','" + Type + "','" + bed + "'," + price + ")";
                fn.setData(query, "Room Added");


                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Please fill in all the required information.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtRoomTypes.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrices.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this,null);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex]; 

                
                txtRoomNumber.Text = row.Cells[0].Value.ToString();
                txtRoomTypes.Text = row.Cells[1].Value.ToString();
                txtBed.Text = row.Cells[2].Value.ToString();
                
            }

        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {

        }

       


    }
}
