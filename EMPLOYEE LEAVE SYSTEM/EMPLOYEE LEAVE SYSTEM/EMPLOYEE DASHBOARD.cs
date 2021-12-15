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
    public partial class EMPLOYEE_DASHBOARD : Form
    {
        public EMPLOYEE_DASHBOARD()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           this.leave_Calender1.Visible = true;
        	this.leave_Calender1.BringToFront();
        	this.employee_dash1.Visible = false;
        	this.apply_Leave21.Visible = false;	
        	this.apply_Leave1.Visible = false;
        }
		void Button1Click(object sender, EventArgs e)
		{
			
			this.apply_Leave1.Visible = true;
        	this.apply_Leave1.BringToFront();
        	this.employee_dash1.Visible = false;
        	this.apply_Leave21.Visible = false;	
		}
		void Button5Click(object sender, EventArgs e)
		{
			this.Close();
			MainForm Form4 = new MainForm();
			Form4.Show();
			
		}

        private void Button6_Click(object sender, EventArgs e)
        {
           	this.user_Profile1.Visible = true;
        	this.user_Profile1.BringToFront();
        	this.employee_dash1.Visible = false;
        	this.apply_Leave21.Visible = false;	
        	this.apply_Leave1.Visible=false;
        }
		void Button3Click(object sender, EventArgs e)
		{
			this.employee_dash1.Visible = true;
        	this.employee_dash1.BringToFront();
        	this.apply_Leave1.Visible = false;
        	this.apply_Leave21.Visible = false;	
		}
		
    }
}
