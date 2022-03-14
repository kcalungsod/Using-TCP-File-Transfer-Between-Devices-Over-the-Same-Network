/*
 * Created by SharpDevelop.
 * Date: 2/11/2021
 * Time: 11:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace File_Transfer_TCP
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
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_clientClick(object sender, EventArgs e)
		{
			Client frm = new Client();
			frm.Show();
			this.Hide();
		}
		
		void Btn_serverClick(object sender, EventArgs e)
		{
			Server frm = new Server();
			frm.Show();
			this.Hide();
		}
		
		
		void Btn_exitClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
