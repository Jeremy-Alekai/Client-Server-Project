/*
 * Created by SharpDevelop.
 * User: Franklin Bruni
 * Date: 15/12/2021
 * Time: 10:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace EMPLOYEE_LEAVE_SYSTEM
{
	partial class employee_dash
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label19;
		
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Button7 = new System.Windows.Forms.Button();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Location = new System.Drawing.Point(60, 333);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1163, 507);
			this.dataGridView1.TabIndex = 66;
			// 
			// Panel2
			// 
			this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Panel2.Controls.Add(this.Label8);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Location = new System.Drawing.Point(60, 79);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(354, 148);
			this.Panel2.TabIndex = 55;
			// 
			// Label8
			// 
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label8.ForeColor = System.Drawing.Color.White;
			this.Label8.Location = new System.Drawing.Point(175, 74);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(24, 25);
			this.Label8.TabIndex = 9;
			this.Label8.Text = "5";
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label6.ForeColor = System.Drawing.Color.White;
			this.Label6.Location = new System.Drawing.Point(134, 32);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(161, 25);
			this.Label6.TabIndex = 8;
			this.Label6.Text = " Leave Balance";
			// 
			// Button7
			// 
			this.Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button7.ForeColor = System.Drawing.Color.White;
			this.Button7.Location = new System.Drawing.Point(968, 846);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(209, 53);
			this.Button7.TabIndex = 64;
			this.Button7.Text = "Export";
			this.Button7.UseVisualStyleBackColor = false;
			// 
			// Label17
			// 
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.Color.Black;
			this.Label17.Location = new System.Drawing.Point(599, 297);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(94, 20);
			this.Label17.TabIndex = 63;
			this.Label17.Text = " Leave Type";
			// 
			// Label18
			// 
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.Color.Black;
			this.Label18.Location = new System.Drawing.Point(743, 297);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(153, 20);
			this.Label18.TabIndex = 62;
			this.Label18.Text = "Approved Authourity";
			// 
			// Label16
			// 
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.Color.Black;
			this.Label16.Location = new System.Drawing.Point(509, 297);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(38, 20);
			this.Label16.TabIndex = 61;
			this.Label16.Text = "End";
			// 
			// Label15
			// 
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.Color.Black;
			this.Label15.Location = new System.Drawing.Point(418, 297);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(44, 20);
			this.Label15.TabIndex = 60;
			this.Label15.Text = "Start";
			// 
			// Label14
			// 
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.Color.Black;
			this.Label14.Location = new System.Drawing.Point(282, 297);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(94, 20);
			this.Label14.TabIndex = 59;
			this.Label14.Text = "Department";
			// 
			// Label13
			// 
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.Color.Black;
			this.Label13.Location = new System.Drawing.Point(173, 297);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(70, 20);
			this.Label13.TabIndex = 58;
			this.Label13.Text = "Duration";
			// 
			// Label11
			// 
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(82, 297);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(44, 20);
			this.Label11.TabIndex = 57;
			this.Label11.Text = "Date";
			// 
			// Label12
			// 
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Label12.Location = new System.Drawing.Point(55, 264);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(146, 25);
			this.Label12.TabIndex = 54;
			this.Label12.Text = " Leave Report";
			// 
			// Panel3
			// 
			this.Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.Panel3.Controls.Add(this.Label9);
			this.Panel3.Controls.Add(this.Label10);
			this.Panel3.Location = new System.Drawing.Point(585, 79);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(346, 148);
			this.Panel3.TabIndex = 56;
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label9.ForeColor = System.Drawing.Color.White;
			this.Label9.Location = new System.Drawing.Point(221, 69);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(36, 25);
			this.Label9.TabIndex = 9;
			this.Label9.Text = "12";
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label10.ForeColor = System.Drawing.Color.White;
			this.Label10.Location = new System.Drawing.Point(180, 27);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(143, 25);
			this.Label10.TabIndex = 8;
			this.Label10.Text = "Total  Leaves";
			// 
			// Label19
			// 
			this.Label19.AutoSize = true;
			this.Label19.BackColor = System.Drawing.Color.White;
			this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.Label19.Location = new System.Drawing.Point(225, 39);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(75, 26);
			this.Label19.TabIndex = 65;
			this.Label19.Text = "Name";
			// 
			// employee_dash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Panel2);
			this.Controls.Add(this.Button7);
			this.Controls.Add(this.Label17);
			this.Controls.Add(this.Label18);
			this.Controls.Add(this.Label16);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.Label14);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.Panel3);
			this.Controls.Add(this.Label19);
			this.Name = "employee_dash";
			this.Size = new System.Drawing.Size(1281, 1053);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
