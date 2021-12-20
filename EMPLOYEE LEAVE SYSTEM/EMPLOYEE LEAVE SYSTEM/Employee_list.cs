/*
 * Created by SharpDevelop.
 * User: Franklin Bruni
 * Date: 15/12/2021
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EMPLOYEE_LEAVE_SYSTEM
{
	/// <summary>
	/// Description of Employee_list.
	/// </summary>
	public partial class Employee_list : UserControl
	{
		public Employee_list()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void button1_Click(object sender, EventArgs e)
        {
            
             Register_Employee form1 = new Register_Employee();
             form1.ShowDialog();
        }
	}
}
