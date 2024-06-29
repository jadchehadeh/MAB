/*
 * Created by SharpDevelop.
 * User: Eng. moayad azab
 * Date: 6/25/2024
 * Time: 04:12 م
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MAB_WORKER_MANAGEMENT_SYSTEM
{
	/// <summary>
	/// Description of ManPowerForm.
	/// </summary>
	public partial class ManPowerForm : Form
	{
		public ManPowerForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		void BtnBackClick(object sender, EventArgs e)
		{
			Dashbaord dashboard = new Dashbaord();
			this.Hide();
			dashboard.Show();
		}
		void Button1Click(object sender, EventArgs e)
		{
			try
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Eng. moayad azab\Desktop\MAB SOFTWARE\MAB\MAB SOFTWARE\MAB WORKER MANAGEMENT SYSTEM\MAB WORKER MANAGEMENT SYSTEM\MAB_DATA_BASE.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                MessageBox.Show("Connection Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
	        }
	        catch (OleDbException ex)
	        {
	            MessageBox.Show("Database connection failed: "+ex.Message, "Connection Failed", MessageBoxButtons.OK);
	        }
	        catch (System.IO.FileNotFoundException ex)
	        {
	            MessageBox.Show("Database file not found: "+ex.Message, "File Not Found", MessageBoxButtons.OK);
	        }
	        catch (Exception ex)
	        {
	            MessageBox.Show("An error occurred: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	        }
			}
		
	}
}
