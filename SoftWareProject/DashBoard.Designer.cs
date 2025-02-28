namespace SoftWareProject
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.btnMiniSize = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegis = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetail = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExitDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employee1 = new SoftWareProject.User_Control.UC_Employee();
            this.uC_CustomerDetail1 = new SoftWareProject.User_Control.UC_CustomerDetail();
            this.uC_CheckOut1 = new SoftWareProject.User_Control.UC_CheckOut();
            this.uC_CustomerRegis1 = new SoftWareProject.User_Control.UC_CustomerRegis();
            this.uC_AddRoom1 = new SoftWareProject.User_Control.UC_AddRoom();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMiniSize
            // 
            this.btnMiniSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMiniSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMiniSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMiniSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMiniSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMiniSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMiniSize.ForeColor = System.Drawing.Color.White;
            this.btnMiniSize.Image = ((System.Drawing.Image)(resources.GetObject("btnMiniSize.Image")));
            this.btnMiniSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMiniSize.Location = new System.Drawing.Point(50, 12);
            this.btnMiniSize.Name = "btnMiniSize";
            this.btnMiniSize.Size = new System.Drawing.Size(67, 45);
            this.btnMiniSize.TabIndex = 0;
            this.btnMiniSize.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BorderRadius = 18;
            this.btnAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnAddRoom.BorderThickness = 1;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(12, 26);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(117, 66);
            this.btnAddRoom.TabIndex = 1;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnCustomerRegis
            // 
            this.btnCustomerRegis.BorderRadius = 18;
            this.btnCustomerRegis.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCustomerRegis.BorderThickness = 1;
            this.btnCustomerRegis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRegis.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegis.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegis.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRegis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRegis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomerRegis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRegis.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegis.Location = new System.Drawing.Point(12, 111);
            this.btnCustomerRegis.Name = "btnCustomerRegis";
            this.btnCustomerRegis.Size = new System.Drawing.Size(117, 66);
            this.btnCustomerRegis.TabIndex = 1;
            this.btnCustomerRegis.Text = "Customer Registration";
            this.btnCustomerRegis.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 18;
            this.btnCheckOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCheckOut.BorderThickness = 1;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(12, 202);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(117, 66);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.BorderRadius = 18;
            this.btnCustomerDetail.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnCustomerDetail.BorderThickness = 1;
            this.btnCustomerDetail.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomerDetail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Location = new System.Drawing.Point(12, 297);
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(117, 66);
            this.btnCustomerDetail.TabIndex = 1;
            this.btnCustomerDetail.Text = "Customer Detail";
            this.btnCustomerDetail.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerRegis);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Controls.Add(this.btnCustomerDetail);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 488);
            this.panel1.TabIndex = 2;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 18;
            this.btnEmployee.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnEmployee.BorderThickness = 1;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(12, 389);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(117, 66);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnExitDashboard
            // 
            this.btnExitDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExitDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExitDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExitDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExitDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnExitDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitDashboard.ForeColor = System.Drawing.Color.White;
            this.btnExitDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnExitDashboard.Image")));
            this.btnExitDashboard.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExitDashboard.Location = new System.Drawing.Point(12, 12);
            this.btnExitDashboard.Name = "btnExitDashboard";
            this.btnExitDashboard.Size = new System.Drawing.Size(46, 45);
            this.btnExitDashboard.TabIndex = 4;
            this.btnExitDashboard.Click += new System.EventHandler(this.btnExitDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetail1);
            this.panel2.Controls.Add(this.uC_CheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegis1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Location = new System.Drawing.Point(178, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 539);
            this.panel2.TabIndex = 3;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(-1, -1);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1163, 539);
            this.uC_Employee1.TabIndex = 4;
            this.uC_Employee1.Load += new System.EventHandler(this.uC_Employee1_Load);
            // 
            // uC_CustomerDetail1
            // 
            this.uC_CustomerDetail1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetail1.Location = new System.Drawing.Point(0, -2);
            this.uC_CustomerDetail1.Name = "uC_CustomerDetail1";
            this.uC_CustomerDetail1.Size = new System.Drawing.Size(1062, 543);
            this.uC_CustomerDetail1.TabIndex = 3;
            // 
            // uC_CheckOut1
            // 
            this.uC_CheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CheckOut1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_CheckOut1.Location = new System.Drawing.Point(-1, -2);
            this.uC_CheckOut1.Name = "uC_CheckOut1";
            this.uC_CheckOut1.Size = new System.Drawing.Size(1104, 542);
            this.uC_CheckOut1.TabIndex = 2;
            this.uC_CheckOut1.Load += new System.EventHandler(this.uC_CheckOut1_Load);
            // 
            // uC_CustomerRegis1
            // 
            this.uC_CustomerRegis1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegis1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_CustomerRegis1.Location = new System.Drawing.Point(-1, -1);
            this.uC_CustomerRegis1.Name = "uC_CustomerRegis1";
            this.uC_CustomerRegis1.Size = new System.Drawing.Size(1170, 542);
            this.uC_CustomerRegis1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, -2);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1166, 540);
            this.uC_AddRoom1.TabIndex = 0;
            this.uC_AddRoom1.Load += new System.EventHandler(this.uC_AddRoom1_Load);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogout.Location = new System.Drawing.Point(109, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(34, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1370, 566);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExitDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMiniSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnMiniSize;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegis;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetail;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnExitDashboard;
        private System.Windows.Forms.Panel panel2;
        private User_Control.UC_AddRoom uC_AddRoom1;
        private User_Control.UC_CustomerRegis uC_CustomerRegis1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private User_Control.UC_CheckOut uC_CheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private User_Control.UC_CustomerDetail uC_CustomerDetail1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private User_Control.UC_Employee uC_Employee1;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}