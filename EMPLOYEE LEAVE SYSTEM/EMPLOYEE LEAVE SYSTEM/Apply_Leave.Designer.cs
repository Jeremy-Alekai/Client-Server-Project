/*
 * Created by SharpDevelop.
 * User: Franklin Bruni
 * Date: 15/12/2021
 * Time: 14:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EMPLOYEE_LEAVE_SYSTEM
{
	partial class Apply_Leave
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
        private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.Label13 = new System.Windows.Forms.Label();
            this.dtpdatestart = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.rdoWithoutPay = new System.Windows.Forms.RadioButton();
            this.txtreasons = new System.Windows.Forms.RichTextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.dtpNotfallWeekened = new System.Windows.Forms.DateTimePicker();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtnoDays = new System.Windows.Forms.TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtemid = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.rdowithPay = new System.Windows.Forms.RadioButton();
            this.dtpApplied = new System.Windows.Forms.DateTimePicker();
            this.rdoAcidentOnDuty = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoFuneral = new System.Windows.Forms.RadioButton();
            this.rdoMaternity = new System.Windows.Forms.RadioButton();
            this.rdoPaternity = new System.Windows.Forms.RadioButton();
            this.rdoVacation = new System.Windows.Forms.RadioButton();
            this.rdoSick = new System.Windows.Forms.RadioButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.dtpenddate);
            this.GroupBox5.Controls.Add(this.Label13);
            this.GroupBox5.Controls.Add(this.dtpdatestart);
            this.GroupBox5.Controls.Add(this.dtpTimeTo);
            this.GroupBox5.Controls.Add(this.Label8);
            this.GroupBox5.Controls.Add(this.Label9);
            this.GroupBox5.Controls.Add(this.dtpTimeFrom);
            this.GroupBox5.Controls.Add(this.Label10);
            this.GroupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(65, 440);
            this.GroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox5.Size = new System.Drawing.Size(1110, 166);
            this.GroupBox5.TabIndex = 56;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "                              From                                               " +
    "                              To";
            // 
            // dtpenddate
            // 
            this.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenddate.Location = new System.Drawing.Point(664, 42);
            this.dtpenddate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(167, 30);
            this.dtpenddate.TabIndex = 30;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(546, 48);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(109, 24);
            this.Label13.TabIndex = 29;
            this.Label13.Text = "End Date :";
            // 
            // dtpdatestart
            // 
            this.dtpdatestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatestart.Location = new System.Drawing.Point(219, 43);
            this.dtpdatestart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpdatestart.Name = "dtpdatestart";
            this.dtpdatestart.Size = new System.Drawing.Size(227, 30);
            this.dtpdatestart.TabIndex = 28;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(664, 94);
            this.dtpTimeTo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.Size = new System.Drawing.Size(167, 30);
            this.dtpTimeTo.TabIndex = 22;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(126, 100);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(69, 24);
            this.Label8.TabIndex = 19;
            this.Label8.Text = "Time :";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(584, 102);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(69, 24);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "Time :";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(219, 95);
            this.dtpTimeFrom.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.Size = new System.Drawing.Size(140, 30);
            this.dtpTimeFrom.TabIndex = 20;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(54, 49);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(128, 24);
            this.Label10.TabIndex = 27;
            this.Label10.Text = "Leave Date :";
            // 
            // rdoWithoutPay
            // 
            this.rdoWithoutPay.AutoSize = true;
            this.rdoWithoutPay.Location = new System.Drawing.Point(60, 74);
            this.rdoWithoutPay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdoWithoutPay.Name = "rdoWithoutPay";
            this.rdoWithoutPay.Size = new System.Drawing.Size(150, 28);
            this.rdoWithoutPay.TabIndex = 0;
            this.rdoWithoutPay.Text = "Without Pay";
            this.rdoWithoutPay.UseVisualStyleBackColor = true;
            // 
            // txtreasons
            // 
            this.txtreasons.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreasons.Location = new System.Drawing.Point(9, 34);
            this.txtreasons.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtreasons.Name = "txtreasons";
            this.txtreasons.Size = new System.Drawing.Size(1088, 95);
            this.txtreasons.TabIndex = 0;
            this.txtreasons.Text = "";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(556, 42);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(148, 65);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(42, 62);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(633, 24);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "Please specify DAY-OFF schedule if it does not fall on a weekened";
            // 
            // dtpNotfallWeekened
            // 
            this.dtpNotfallWeekened.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNotfallWeekened.Location = new System.Drawing.Point(704, 52);
            this.dtpNotfallWeekened.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpNotfallWeekened.Name = "dtpNotfallWeekened";
            this.dtpNotfallWeekened.Size = new System.Drawing.Size(396, 30);
            this.dtpNotfallWeekened.TabIndex = 17;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtreasons);
            this.GroupBox4.Controls.Add(this.btnNew);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Controls.Add(this.dtpNotfallWeekened);
            this.GroupBox4.Controls.Add(this.txtnoDays);
            this.GroupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(56, 604);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox4.Size = new System.Drawing.Size(1110, 143);
            this.GroupBox4.TabIndex = 55;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Tag = "Reasons";
            this.GroupBox4.Text = "Other Reasons";
            // 
            // txtnoDays
            // 
            this.txtnoDays.Location = new System.Drawing.Point(704, 52);
            this.txtnoDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnoDays.Name = "txtnoDays";
            this.txtnoDays.Size = new System.Drawing.Size(148, 35);
            this.txtnoDays.TabIndex = 8;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(392, 768);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(154, 40);
            this.btnHistory.TabIndex = 60;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 768);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 40);
            this.button1.TabIndex = 58;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtsalary);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.lblcode);
            this.GroupBox1.Controls.Add(this.txtdepartment);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtEmployeeId);
            this.GroupBox1.Controls.Add(this.txtposition);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.btnsearch);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtemid);
            this.GroupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(65, 86);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox1.Size = new System.Drawing.Size(1110, 168);
            this.GroupBox1.TabIndex = 53;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Employee\'s Details";
            // 
            // txtsalary
            // 
            this.txtsalary.Enabled = false;
            this.txtsalary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(718, 91);
            this.txtsalary.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.ReadOnly = true;
            this.txtsalary.Size = new System.Drawing.Size(356, 38);
            this.txtsalary.TabIndex = 12;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(586, 106);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 24);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Salary :";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(914, 168);
            this.lblcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(190, 24);
            this.lblcode.TabIndex = 13;
            this.lblcode.Text = "HR Form-011 (ALA)";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Enabled = false;
            this.txtdepartment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdepartment.Location = new System.Drawing.Point(202, 91);
            this.txtdepartment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtdepartment.Multiline = true;
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.ReadOnly = true;
            this.txtdepartment.Size = new System.Drawing.Size(358, 38);
            this.txtdepartment.TabIndex = 10;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(21, 57);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(132, 24);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Employee Id:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(21, 106);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(133, 24);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Department :";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEmployeeId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEmployeeId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Location = new System.Drawing.Point(202, 42);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(358, 35);
            this.txtEmployeeId.TabIndex = 4;
            // 
            // txtposition
            // 
            this.txtposition.Enabled = false;
            this.txtposition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposition.Location = new System.Drawing.Point(718, 38);
            this.txtposition.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtposition.Multiline = true;
            this.txtposition.Name = "txtposition";
            this.txtposition.ReadOnly = true;
            this.txtposition.Size = new System.Drawing.Size(356, 38);
            this.txtposition.TabIndex = 8;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(586, 57);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 24);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Position :";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(591, 203);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(111, 43);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Text = "Find";
            this.btnsearch.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(116, 212);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(138, 24);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Employee Id :";
            // 
            // txtemid
            // 
            this.txtemid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemid.Location = new System.Drawing.Point(280, 203);
            this.txtemid.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtemid.Multiline = true;
            this.txtemid.Name = "txtemid";
            this.txtemid.Size = new System.Drawing.Size(280, 41);
            this.txtemid.TabIndex = 2;
            this.txtemid.Tag = "Employee Id";
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Bernard MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(44, 32);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(584, 49);
            this.Label12.TabIndex = 57;
            this.Label12.Text = "Apply for Leave ";
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(40, 49);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 20);
            this.Label1.TabIndex = 51;
            this.Label1.Text = "Date :";
            // 
            // rdowithPay
            // 
            this.rdowithPay.AutoSize = true;
            this.rdowithPay.Checked = true;
            this.rdowithPay.Location = new System.Drawing.Point(60, 31);
            this.rdowithPay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdowithPay.Name = "rdowithPay";
            this.rdowithPay.Size = new System.Drawing.Size(119, 28);
            this.rdowithPay.TabIndex = 0;
            this.rdowithPay.TabStop = true;
            this.rdowithPay.Text = "With Pay";
            this.rdowithPay.UseVisualStyleBackColor = true;
            // 
            // dtpApplied
            // 
            this.dtpApplied.Location = new System.Drawing.Point(44, 40);
            this.dtpApplied.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtpApplied.Name = "dtpApplied";
            this.dtpApplied.Size = new System.Drawing.Size(397, 26);
            this.dtpApplied.TabIndex = 52;
            // 
            // rdoAcidentOnDuty
            // 
            this.rdoAcidentOnDuty.AutoSize = true;
            this.rdoAcidentOnDuty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAcidentOnDuty.Location = new System.Drawing.Point(690, 103);
            this.rdoAcidentOnDuty.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdoAcidentOnDuty.Name = "rdoAcidentOnDuty";
            this.rdoAcidentOnDuty.Size = new System.Drawing.Size(201, 28);
            this.rdoAcidentOnDuty.TabIndex = 7;
            this.rdoAcidentOnDuty.Text = "Accident On Duty";
            this.rdoAcidentOnDuty.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.rdoAcidentOnDuty);
            this.GroupBox2.Controls.Add(this.radioButton1);
            this.GroupBox2.Controls.Add(this.rdoFuneral);
            this.GroupBox2.Controls.Add(this.rdoMaternity);
            this.GroupBox2.Controls.Add(this.rdoPaternity);
            this.GroupBox2.Controls.Add(this.rdoVacation);
            this.GroupBox2.Controls.Add(this.rdoSick);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(65, 266);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox2.Size = new System.Drawing.Size(1113, 163);
            this.GroupBox2.TabIndex = 54;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Leave Applied For";
            // 
            // rdoFuneral
            // 
            this.rdoFuneral.AutoSize = true;
            this.rdoFuneral.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFuneral.Location = new System.Drawing.Point(690, 60);
            this.rdoFuneral.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdoFuneral.Name = "rdoFuneral";
            this.rdoFuneral.Size = new System.Drawing.Size(106, 28);
            this.rdoFuneral.TabIndex = 6;
            this.rdoFuneral.Text = "Funeral";
            this.rdoFuneral.UseVisualStyleBackColor = true;
            // 
            // rdoMaternity
            // 
            this.rdoMaternity.AutoSize = true;
            this.rdoMaternity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaternity.Location = new System.Drawing.Point(531, 103);
            this.rdoMaternity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdoMaternity.Name = "rdoMaternity";
            this.rdoMaternity.Size = new System.Drawing.Size(124, 28);
            this.rdoMaternity.TabIndex = 5;
            this.rdoMaternity.Text = "Maternity";
            this.rdoMaternity.UseVisualStyleBackColor = true;
            // 
            // rdoPaternity
            // 
            this.rdoPaternity.AutoSize = true;
            this.rdoPaternity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPaternity.Location = new System.Drawing.Point(382, 103);
            this.rdoPaternity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdoPaternity.Name = "rdoPaternity";
            this.rdoPaternity.Size = new System.Drawing.Size(120, 28);
            this.rdoPaternity.TabIndex = 4;
            this.rdoPaternity.Text = "Paternity";
            this.rdoPaternity.UseVisualStyleBackColor = true;
            // 
            // rdoVacation
            // 
            this.rdoVacation.AutoSize = true;
            this.rdoVacation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVacation.Location = new System.Drawing.Point(536, 60);
            this.rdoVacation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdoVacation.Name = "rdoVacation";
            this.rdoVacation.Size = new System.Drawing.Size(116, 28);
            this.rdoVacation.TabIndex = 3;
            this.rdoVacation.Text = "Vacation";
            this.rdoVacation.UseVisualStyleBackColor = true;
            // 
            // rdoSick
            // 
            this.rdoSick.AutoSize = true;
            this.rdoSick.Checked = true;
            this.rdoSick.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSick.Location = new System.Drawing.Point(382, 60);
            this.rdoSick.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rdoSick.Name = "rdoSick";
            this.rdoSick.Size = new System.Drawing.Size(75, 28);
            this.rdoSick.TabIndex = 2;
            this.rdoSick.TabStop = true;
            this.rdoSick.Text = "Sick";
            this.rdoSick.UseVisualStyleBackColor = true;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.rdoWithoutPay);
            this.GroupBox3.Controls.Add(this.rdowithPay);
            this.GroupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(26, 29);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GroupBox3.Size = new System.Drawing.Size(322, 123);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Option";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(228, 768);
            this.btn_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(154, 40);
            this.btn_new.TabIndex = 59;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(903, 60);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 28);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Academic";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Apply_Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dtpApplied);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.btn_new);
            this.Name = "Apply_Leave";
            this.Size = new System.Drawing.Size(1310, 909);
            this.Load += new System.EventHandler(this.Apply_LeaveLoad);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.DateTimePicker dtpenddate;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.DateTimePicker dtpdatestart;
        internal System.Windows.Forms.DateTimePicker dtpTimeTo;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.DateTimePicker dtpTimeFrom;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.RadioButton rdoWithoutPay;
        internal System.Windows.Forms.RichTextBox txtreasons;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DateTimePicker dtpNotfallWeekened;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox txtnoDays;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtsalary;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label lblcode;
        internal System.Windows.Forms.TextBox txtdepartment;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtEmployeeId;
        internal System.Windows.Forms.TextBox txtposition;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnsearch;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtemid;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RadioButton rdowithPay;
        internal System.Windows.Forms.DateTimePicker dtpApplied;
        internal System.Windows.Forms.RadioButton rdoAcidentOnDuty;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton rdoFuneral;
        internal System.Windows.Forms.RadioButton rdoMaternity;
        internal System.Windows.Forms.RadioButton rdoPaternity;
        internal System.Windows.Forms.RadioButton rdoVacation;
        internal System.Windows.Forms.RadioButton rdoSick;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button btn_new;
        internal System.Windows.Forms.RadioButton radioButton1;
	}
}
