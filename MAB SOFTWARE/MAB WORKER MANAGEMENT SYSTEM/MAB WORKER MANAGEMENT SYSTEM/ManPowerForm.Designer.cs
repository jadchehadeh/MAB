/*
 * Created by SharpDevelop.
 * User: Eng. moayad azab
 * Date: 6/25/2024
 * Time: 04:12 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MAB_WORKER_MANAGEMENT_SYSTEM
{
	partial class ManPowerForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnTotal;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnRelease;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManPowerForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnRelease = new System.Windows.Forms.Button();
			this.btnRegister = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnTotal = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
			this.panel1.Controls.Add(this.btnBack);
			this.panel1.Controls.Add(this.btnRelease);
			this.panel1.Controls.Add(this.btnRegister);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.btnTotal);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(170, 987);
			this.panel1.TabIndex = 0;
			// 
			// btnBack
			// 
			this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
			this.btnBack.Location = new System.Drawing.Point(17, 803);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(150, 110);
			this.btnBack.TabIndex = 6;
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// btnRelease
			// 
			this.btnRelease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRelease.BackgroundImage")));
			this.btnRelease.Location = new System.Drawing.Point(17, 586);
			this.btnRelease.Name = "btnRelease";
			this.btnRelease.Size = new System.Drawing.Size(150, 110);
			this.btnRelease.TabIndex = 5;
			this.btnRelease.UseVisualStyleBackColor = true;
			// 
			// btnRegister
			// 
			this.btnRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegister.BackgroundImage")));
			this.btnRegister.Location = new System.Drawing.Point(17, 343);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(150, 110);
			this.btnRegister.TabIndex = 4;
			this.btnRegister.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(17, 352);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(136, 92);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(17, 812);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 92);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(17, 604);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 92);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnTotal
			// 
			this.btnTotal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTotal.BackgroundImage")));
			this.btnTotal.Location = new System.Drawing.Point(17, 104);
			this.btnTotal.Name = "btnTotal";
			this.btnTotal.Size = new System.Drawing.Size(150, 110);
			this.btnTotal.TabIndex = 0;
			this.btnTotal.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(543, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(249, 140);
			this.button1.TabIndex = 1;
			this.button1.Text = "Test Connection";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// ManPowerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1902, 1033);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ManPowerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManPower";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
