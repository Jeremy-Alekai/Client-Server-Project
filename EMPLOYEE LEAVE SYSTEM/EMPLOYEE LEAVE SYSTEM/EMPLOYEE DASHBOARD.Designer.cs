namespace EMPLOYEE_LEAVE_SYSTEM
{
    partial class EMPLOYEE_DASHBOARD
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMPLOYEE_DASHBOARD));
        	this.Label1 = new System.Windows.Forms.Label();
        	this.Panel4 = new System.Windows.Forms.Panel();
        	this.Label5 = new System.Windows.Forms.Label();
        	this.btn_emp_Dash = new System.Windows.Forms.Button();
        	this.btn_empProfile = new System.Windows.Forms.Button();
        	this.btnLogout = new System.Windows.Forms.Button();
        	this.btnLeave_Calender = new System.Windows.Forms.Button();
        	this.btn_ApplyLeave = new System.Windows.Forms.Button();
        	this.Label2 = new System.Windows.Forms.Label();
        	this.Label4 = new System.Windows.Forms.Label();
        	this.Label3 = new System.Windows.Forms.Label();
        	this.Panel1 = new System.Windows.Forms.Panel();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.employee_dash1 = new EMPLOYEE_LEAVE_SYSTEM.employee_dash();
        	this.apply_Leave1 = new EMPLOYEE_LEAVE_SYSTEM.Apply_Leave();
        	this.apply_Leave21 = new EMPLOYEE_LEAVE_SYSTEM.Apply_Leave2();
        	this.user_Profile1 = new EMPLOYEE_LEAVE_SYSTEM.User_Profile();
        	this.leave_Calender1 = new EMPLOYEE_LEAVE_SYSTEM.Leave_Calender();
        	this.Panel4.SuspendLayout();
        	this.Panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// Label1
        	// 
        	this.Label1.AutoSize = true;
        	this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label1.ForeColor = System.Drawing.Color.White;
        	this.Label1.Location = new System.Drawing.Point(27, 19);
        	this.Label1.Name = "Label1";
        	this.Label1.Size = new System.Drawing.Size(127, 26);
        	this.Label1.TabIndex = 0;
        	this.Label1.Text = "Dashboard";
        	// 
        	// Panel4
        	// 
        	this.Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        	this.Panel4.Controls.Add(this.Label5);
        	this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
        	this.Panel4.Location = new System.Drawing.Point(193, 0);
        	this.Panel4.Name = "Panel4";
        	this.Panel4.Size = new System.Drawing.Size(1417, 68);
        	this.Panel4.TabIndex = 52;
        	// 
        	// Label5
        	// 
        	this.Label5.AutoSize = true;
        	this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        	this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label5.ForeColor = System.Drawing.Color.White;
        	this.Label5.Location = new System.Drawing.Point(312, 19);
        	this.Label5.Name = "Label5";
        	this.Label5.Size = new System.Drawing.Size(240, 26);
        	this.Label5.TabIndex = 7;
        	this.Label5.Text = "Employee Dashboard";
        	// 
        	// btn_emp_Dash
        	// 
        	this.btn_emp_Dash.Location = new System.Drawing.Point(12, 182);
        	this.btn_emp_Dash.Name = "btn_emp_Dash";
        	this.btn_emp_Dash.Size = new System.Drawing.Size(159, 35);
        	this.btn_emp_Dash.TabIndex = 18;
        	this.btn_emp_Dash.Text = "DashBoard";
        	this.btn_emp_Dash.UseVisualStyleBackColor = true;
        	this.btn_emp_Dash.Click += new System.EventHandler(this.Button3Click);
        	// 
        	// btn_empProfile
        	// 
        	this.btn_empProfile.Location = new System.Drawing.Point(12, 357);
        	this.btn_empProfile.Name = "btn_empProfile";
        	this.btn_empProfile.Size = new System.Drawing.Size(159, 35);
        	this.btn_empProfile.TabIndex = 17;
        	this.btn_empProfile.Text = "Employee profile";
        	this.btn_empProfile.UseVisualStyleBackColor = true;
        	this.btn_empProfile.Click += new System.EventHandler(this.Button6_Click);
        	// 
        	// btnLogout
        	// 
        	this.btnLogout.Location = new System.Drawing.Point(12, 542);
        	this.btnLogout.Name = "btnLogout";
        	this.btnLogout.Size = new System.Drawing.Size(159, 35);
        	this.btnLogout.TabIndex = 16;
        	this.btnLogout.Text = "LOGOUT";
        	this.btnLogout.UseVisualStyleBackColor = true;
        	this.btnLogout.Click += new System.EventHandler(this.Button5Click);
        	// 
        	// btnLeave_Calender
        	// 
        	this.btnLeave_Calender.Location = new System.Drawing.Point(12, 299);
        	this.btnLeave_Calender.Name = "btnLeave_Calender";
        	this.btnLeave_Calender.Size = new System.Drawing.Size(159, 35);
        	this.btnLeave_Calender.TabIndex = 15;
        	this.btnLeave_Calender.Text = "Leave calender";
        	this.btnLeave_Calender.UseVisualStyleBackColor = true;
        	this.btnLeave_Calender.Click += new System.EventHandler(this.Button4_Click);
        	// 
        	// btn_ApplyLeave
        	// 
        	this.btn_ApplyLeave.Location = new System.Drawing.Point(12, 235);
        	this.btn_ApplyLeave.Name = "btn_ApplyLeave";
        	this.btn_ApplyLeave.Size = new System.Drawing.Size(159, 35);
        	this.btn_ApplyLeave.TabIndex = 12;
        	this.btn_ApplyLeave.Text = "Apply For leave";
        	this.btn_ApplyLeave.UseVisualStyleBackColor = true;
        	this.btn_ApplyLeave.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// Label2
        	// 
        	this.Label2.AutoSize = true;
        	this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label2.ForeColor = System.Drawing.Color.White;
        	this.Label2.Location = new System.Drawing.Point(37, 299);
        	this.Label2.Name = "Label2";
        	this.Label2.Size = new System.Drawing.Size(0, 20);
        	this.Label2.TabIndex = 7;
        	// 
        	// Label4
        	// 
        	this.Label4.AutoSize = true;
        	this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label4.ForeColor = System.Drawing.Color.White;
        	this.Label4.Location = new System.Drawing.Point(27, 309);
        	this.Label4.Name = "Label4";
        	this.Label4.Size = new System.Drawing.Size(0, 20);
        	this.Label4.TabIndex = 9;
        	// 
        	// Label3
        	// 
        	this.Label3.AutoSize = true;
        	this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Label3.ForeColor = System.Drawing.Color.White;
        	this.Label3.Location = new System.Drawing.Point(37, 329);
        	this.Label3.Name = "Label3";
        	this.Label3.Size = new System.Drawing.Size(0, 20);
        	this.Label3.TabIndex = 8;
        	// 
        	// Panel1
        	// 
        	this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        	this.Panel1.Controls.Add(this.pictureBox1);
        	this.Panel1.Controls.Add(this.btn_emp_Dash);
        	this.Panel1.Controls.Add(this.btn_empProfile);
        	this.Panel1.Controls.Add(this.btnLogout);
        	this.Panel1.Controls.Add(this.btnLeave_Calender);
        	this.Panel1.Controls.Add(this.btn_ApplyLeave);
        	this.Panel1.Controls.Add(this.Label2);
        	this.Panel1.Controls.Add(this.Label1);
        	this.Panel1.Controls.Add(this.Label4);
        	this.Panel1.Controls.Add(this.Label3);
        	this.Panel1.Dock = System.Windows.Forms.DockStyle.Left;
        	this.Panel1.Location = new System.Drawing.Point(0, 0);
        	this.Panel1.Name = "Panel1";
        	this.Panel1.Size = new System.Drawing.Size(193, 1000);
        	this.Panel1.TabIndex = 38;
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
        	this.pictureBox1.Location = new System.Drawing.Point(27, 64);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(127, 84);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 19;
        	this.pictureBox1.TabStop = false;
        	// 
        	// employee_dash1
        	// 
        	this.employee_dash1.Location = new System.Drawing.Point(193, 74);
        	this.employee_dash1.Name = "employee_dash1";
        	this.employee_dash1.Size = new System.Drawing.Size(1281, 1053);
        	this.employee_dash1.TabIndex = 53;
        	// 
        	// apply_Leave1
        	// 
        	this.apply_Leave1.Location = new System.Drawing.Point(199, 79);
        	this.apply_Leave1.Name = "apply_Leave1";
        	this.apply_Leave1.Size = new System.Drawing.Size(1405, 909);
        	this.apply_Leave1.TabIndex = 54;
        	// 
        	// apply_Leave21
        	// 
        	this.apply_Leave21.BackColor = System.Drawing.Color.Transparent;
        	this.apply_Leave21.Location = new System.Drawing.Point(225, 74);
        	this.apply_Leave21.Name = "apply_Leave21";
        	this.apply_Leave21.Size = new System.Drawing.Size(1302, 910);
        	this.apply_Leave21.TabIndex = 55;
        	// 
        	// user_Profile1
        	// 
        	this.user_Profile1.Location = new System.Drawing.Point(193, 74);
        	this.user_Profile1.Name = "user_Profile1";
        	this.user_Profile1.Size = new System.Drawing.Size(1337, 870);
        	this.user_Profile1.TabIndex = 56;
        	// 
        	// leave_Calender1
        	// 
        	this.leave_Calender1.Location = new System.Drawing.Point(192, 64);
        	this.leave_Calender1.Name = "leave_Calender1";
        	this.leave_Calender1.Size = new System.Drawing.Size(1422, 933);
        	this.leave_Calender1.TabIndex = 57;
        	// 
        	// EMPLOYEE_DASHBOARD
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1610, 1000);
        	this.ControlBox = false;
        	this.Controls.Add(this.Panel4);
        	this.Controls.Add(this.Panel1);
        	this.Controls.Add(this.employee_dash1);
        	this.Controls.Add(this.user_Profile1);
        	this.Controls.Add(this.apply_Leave21);
        	this.Controls.Add(this.apply_Leave1);
        	this.Controls.Add(this.leave_Calender1);
        	this.Name = "EMPLOYEE_DASHBOARD";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "EMPLOYEE_DASHBOARD";
        	this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        	this.Panel4.ResumeLayout(false);
        	this.Panel4.PerformLayout();
        	this.Panel1.ResumeLayout(false);
        	this.Panel1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btn_emp_Dash;
        internal System.Windows.Forms.Button btn_empProfile;
        internal System.Windows.Forms.Button btnLogout;
        internal System.Windows.Forms.Button btnLeave_Calender;
        internal System.Windows.Forms.Button btn_ApplyLeave;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private EMPLOYEE_LEAVE_SYSTEM.employee_dash employee_dash1;
        private EMPLOYEE_LEAVE_SYSTEM.Apply_Leave apply_Leave1;
        private EMPLOYEE_LEAVE_SYSTEM.Apply_Leave2 apply_Leave21;
        private EMPLOYEE_LEAVE_SYSTEM.User_Profile user_Profile1;
        private EMPLOYEE_LEAVE_SYSTEM.Leave_Calender leave_Calender1;
    }
}