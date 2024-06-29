/*
 * Created by SharpDevelop.
 * User: Eng. moayad azab
 * Date: 6/24/2024
 * Time: 02:23 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MAB_WORKER_MANAGEMENT_SYSTEM
{
	/// <summary>
	/// Description of Dashbaord.
	/// </summary>
	public partial class Dashbaord : Form
	{
		public Dashbaord()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnTotalClick(object sender, EventArgs e)
		{
			
		}
		void BtnTotalWorkersClick(object sender, EventArgs e)
		{
			ManPowerForm manpowerform = new ManPowerForm();
			manpowerform.Show();
			this.Hide();
			
		}
		void DashbaordLoad(object sender, EventArgs e)
		{
	
		}
		
	}
}
