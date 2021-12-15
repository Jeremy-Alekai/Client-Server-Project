using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EMPLOYEE_LEAVE_SYSTEM
{
    public partial class ADMIN_DASHBOARD : Form
    {
        public ADMIN_DASHBOARD()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainForm loginForm = new MainForm();
            loginForm.Show();
            this.Hide();
        }
		void ADMIN_DASHBOARDLoad(object sender, EventArgs e)
		{
	
		}

        private void Button2_Click(object sender, EventArgs e)
        {
        	this.employee_list1.Visible = true;
        	this.employee_list1.BringToFront();
        	this.leave_manager1.Visible = false;
        	this.admin_Dash1.Visible = false;
        	
        }

        private void button5_Click(object sender, EventArgs e)
        {
		this.admin_Dash1.Visible = true;
        	this.admin_Dash1.BringToFront();
        	this.leave_manager1.Visible = false;
        	this.employee_list1.Visible = false;	
        	
        }

        private void button8_Click(object sender, EventArgs e)
        {
		
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
        	
        	this.leave_manager1.Visible= true;
        	
        	this.leave_manager1.BringToFront();
        	this.admin_Dash1.Visible= false;
        	this.employee_list1.Visible= false;
        	
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
		void Button7Click(object sender, EventArgs e)
		{
			this.Close();
			MainForm logout = new MainForm();
				logout.Show();
		}
    }
}
