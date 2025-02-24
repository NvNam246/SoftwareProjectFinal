using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftWareProject.User_Control
{
    public partial class UC_CustomerRegis : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRegis()
        {
            InitializeComponent();
        }

        public void setCombobox(string query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForcombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_CustomerRegis_Load(object sender, EventArgs e)
        {

        }

        private void cbxBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRoomType.SelectedIndex = -1;
            cbxRoomNo.Items.Clear();
            txtPrice.Clear();

        }

        private void cbxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRoomNo.Items.Clear();
            query = "select roomNumber from rooms where bed = '" + cbxBed.Text + "' and roomType = '" + cbxRoomType.Text + "' and booked = 'NO'";
            setCombobox(query,cbxRoomNo);
        }
        int readData;
        private void cbxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select prices, roomID from rooms where roomNumber = '" + cbxRoomNo.Text + "'";
            DataSet ds = fn.GetData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            readData = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && cbxGender.Text != "" && txtDateOfBirth.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string national = txtNationality.Text;
                string gender = cbxGender.Text;
                string dob = txtDateOfBirth.Text;
                string idproof = txtIDProof.Text;
                string address = txtAddress.Text;  
                string checkin = txtCheckIn.Text;


                query = "insert into customer(cname,mobile,nationality,gender,dob,idproof,address,checkin,roomid) values ('" + name + "'," + mobile + ",'" + national + "','" + gender +"','"+dob+ "','" + idproof + "','" + address + "','" + checkin + "'," + readData + ") update rooms set booked = 'YES' where roomNumber = '" + cbxRoomNo.Text + "'";
                fn.setData(query, "Room Number" + cbxRoomNo.Text + "Successfully registered additional customers.");
                clearAll();
             }else
            {
                MessageBox.Show("Please do not leave the fields blank.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            cbxGender.SelectedIndex = -1;
            txtDateOfBirth.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText(); 
            cbxBed.SelectedIndex = -1;
            cbxRoomType.SelectedIndex = -1;
            cbxRoomNo.Items.Clear();
            txtPrice.Clear();



        }

        private void UC_CustomerRegis_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
