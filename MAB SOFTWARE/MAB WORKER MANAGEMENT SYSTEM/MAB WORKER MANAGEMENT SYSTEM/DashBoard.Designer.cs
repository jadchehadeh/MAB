/*
 * Created by SharpDevelop.
 * User: Eng. moayad azab
 * Date: 6/24/2024
 * Time: 02:23 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MAB_WORKER_MANAGEMENT_SYSTEM
{
	partial class Dashbaord
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnManageWorkers;
		private System.Windows.Forms.Button btnManageAbs;
		
		private System.Windows.Forms.Button btnTimeSheet;
		private System.Windows.Forms.Button btnTotalWorkers;
		private System.Windows.Forms.Button btnStoreMangment;
		private System.Windows.Forms.Button btnStaffManagment;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbaord));
			this.btnManageWorkers = new System.Windows.Forms.Button();
			this.btnTimeSheet = new System.Windows.Forms.Button();
			this.btnManageAbs = new System.Windows.Forms.Button();
			this.btnTotalWorkers = new System.Windows.Forms.Button();
			this.btnStoreMangment = new System.Windows.Forms.Button();
			this.btnStaffManagment = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnManageWorkers
			// 
			this.btnManageWorkers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageWorkers.BackgroundImage")));
			this.btnManageWorkers.Location = new System.Drawing.Point(55, 579);
			this.btnManageWorkers.Name = "btnManageWorkers";
			this.btnManageWorkers.Size = new System.Drawing.Size(295, 287);
			this.btnManageWorkers.TabIndex = 0;
			this.btnManageWorkers.UseVisualStyleBackColor = true;
			this.btnManageWorkers.Click += new System.EventHandler(this.BtnTotalWorkersClick);
			// 
			// btnTimeSheet
			// 
			this.btnTimeSheet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimeSheet.BackgroundImage")));
			this.btnTimeSheet.Location = new System.Drawing.Point(487, 579);
			this.btnTimeSheet.Name = "btnTimeSheet";
			this.btnTimeSheet.Size = new System.Drawing.Size(295, 287);
			this.btnTimeSheet.TabIndex = 3;
			this.btnTimeSheet.UseVisualStyleBackColor = true;
			this.btnTimeSheet.Click += new System.EventHandler(this.BtnTotalClick);
			// 
			// btnManageAbs
			// 
			this.btnManageAbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageAbs.BackgroundImage")));
			this.btnManageAbs.Location = new System.Drawing.Point(1442, 579);
			this.btnManageAbs.Name = "btnManageAbs";
			this.btnManageAbs.Size = new System.Drawing.Size(295, 287);
			this.btnManageAbs.TabIndex = 4;
			this.btnManageAbs.UseVisualStyleBackColor = true;
			// 
			// btnTotalWorkers
			// 
			this.btnTotalWorkers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotalWorkers.BackgroundImage")));
			this.btnTotalWorkers.Location = new System.Drawing.Point(956, 579);
			this.btnTotalWorkers.Name = "btnTotalWorkers";
			this.btnTotalWorkers.Size = new System.Drawing.Size(295, 287);
			this.btnTotalWorkers.TabIndex = 5;
			this.btnTotalWorkers.UseVisualStyleBackColor = true;
			this.btnTotalWorkers.Click += new System.EventHandler(this.BtnTotalWorkersClick);
			// 
			// btnStoreMangment
			// 
			this.btnStoreMangment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStoreMangment.BackgroundImage")));
			this.btnStoreMangment.Location = new System.Drawing.Point(55, 125);
			this.btnStoreMangment.Name = "btnStoreMangment";
			this.btnStoreMangment.Size = new System.Drawing.Size(295, 287);
			this.btnStoreMangment.TabIndex = 6;
			this.btnStoreMangment.UseVisualStyleBackColor = true;
			// 
			// btnStaffManagment
			// 
			this.btnStaffManagment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStaffManagment.BackgroundImage")));
			this.btnStaffManagment.Location = new System.Drawing.Point(1442, 159);
			this.btnStaffManagment.Name = "btnStaffManagment";
			this.btnStaffManagment.Size = new System.Drawing.Size(295, 287);
			this.btnStaffManagment.TabIndex = 7;
			this.btnStaffManagment.UseVisualStyleBackColor = true;
			// 
			// Dashbaord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1902, 1033);
			this.Controls.Add(this.btnStaffManagment);
			this.Controls.Add(this.btnStoreMangment);
			this.Controls.Add(this.btnTotalWorkers);
			this.Controls.Add(this.btnManageAbs);
			this.Controls.Add(this.btnTimeSheet);
			this.Controls.Add(this.btnManageWorkers);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Dashbaord";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashbaord - Managment";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.DashbaordLoad);
			this.ResumeLayout(false);

		}
	}
}
