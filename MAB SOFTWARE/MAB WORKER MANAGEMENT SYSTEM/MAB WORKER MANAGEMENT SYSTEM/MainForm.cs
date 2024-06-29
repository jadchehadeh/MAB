/*
 * Created by SharpDevelop.
 * User: Eng. moayad azab
 * Date: 6/22/2024
 * Time: 12:10 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MAB_WORKER_MANAGEMENT_SYSTEM
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
			//Icon = new Icon("..\..\MABLOGO.ico"); // Ensure the path is correct
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
			String Username = txtUserName.Text.ToString();
			String Password = txtPwd.Text.ToString();
//			 if(Username.Equals("Jad_Ch") && Password.Equals("jadjadjad1"))
//			 {
			 	Dashbaord dashboard = new Dashbaord();
			 	dashboard.Show();
//			 }else{
//			 	
//			 	MessageBox.Show("Error User Name or Password","Unable to Login",MessageBoxButtons.OKCancel , MessageBoxIcon.Warning);
//			 
//			 }
		}
		void TxtUserNameTextChanged(object sender, EventArgs e)
		{
	
		}
	}
}
