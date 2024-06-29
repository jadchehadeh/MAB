/*
 * Created by SharpDevelop.
 * User: Eng. moayad azab
 * Date: 6/22/2024
 * Time: 12:10 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MAB_WORKER_MANAGEMENT_SYSTEM
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Username;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPwd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLogin;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Username = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Username
			// 
			this.Username.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Username.ForeColor = System.Drawing.Color.Navy;
			this.Username.Location = new System.Drawing.Point(838, 472);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(228, 29);
			this.Username.TabIndex = 1;
			this.Username.Text = "Username";
			this.Username.Click += new System.EventHandler(this.Label1Click);
			// 
			// txtUserName
			// 
			this.txtUserName.BackColor = System.Drawing.SystemColors.MenuBar;
			this.txtUserName.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(1072, 472);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(234, 32);
			this.txtUserName.TabIndex = 2;
			this.txtUserName.TextChanged += new System.EventHandler(this.TxtUserNameTextChanged);
			// 
			// txtPwd
			// 
			this.txtPwd.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPwd.Location = new System.Drawing.Point(1072, 528);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.Size = new System.Drawing.Size(234, 32);
			this.txtPwd.TabIndex = 4;
			this.txtPwd.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Navy;
			this.label1.Location = new System.Drawing.Point(838, 528);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 32);
			this.label1.TabIndex = 3;
			this.label1.Text = "Password";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// btnLogin
			// 
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnLogin.Location = new System.Drawing.Point(1021, 582);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(123, 29);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1382, 840);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.Username);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MAB WORKER MANAGEMENT SYSTEM";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
