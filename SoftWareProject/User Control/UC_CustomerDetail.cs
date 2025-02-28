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
    public partial class UC_CustomerDetail : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerDetail()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtSeach.SelectedIndex == 0)
            {
                query = "select customer.cid, customer.cname, customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin, rooms.roomNumber,rooms.roomType,rooms.bed, rooms.prices from customer inner join rooms on customer.roomid = rooms.roomID ";
                getRecord(query);



            }else if(txtSeach.SelectedIndex == 1)
            {
                query = "select customer.cid, customer.cname, customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin, rooms.roomNumber,rooms.roomType,rooms.bed, rooms.prices from customer inner join rooms on customer.roomid = rooms.roomID where checkout is null ";
                getRecord(query);
            }
            else if (txtSeach.SelectedIndex == 2)
            {
                query = "select customer.cid, customer.cname, customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idproof,customer.address,customer.checkin, rooms.roomNumber,rooms.roomType,rooms.bed, rooms.prices from customer inner join rooms on customer.roomid = rooms.roomID where checkout is not null ";
                getRecord(query);
            }
        }

        private void getRecord(string query)
        {
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
