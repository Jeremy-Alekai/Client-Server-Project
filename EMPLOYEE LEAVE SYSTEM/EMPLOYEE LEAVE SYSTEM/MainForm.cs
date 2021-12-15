/*
 * Created by SharpDevelop.
 * User: Franklin Bruni
 * Date: 07/12/2021
 * Time: 11:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EMPLOYEE_LEAVE_SYSTEM
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

     
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (txtUSERID.Text == "employee" && txtPass.Text == "123"){
        		EMPLOYEE_DASHBOARD Form1 = new EMPLOYEE_DASHBOARD();
        	    Form1.Show();
        	} 
			else if(txtUSERID.Text == "admin" && txtPass.Text == "123"){
        		ADMIN_DASHBOARD Form2 = new ADMIN_DASHBOARD();
        	    Form2.Show();
        	}
        	
			else{
				MessageBox.Show("Enter Correct User Details", "INVALID LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            	}
			this.Hide();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
        
	}
}
