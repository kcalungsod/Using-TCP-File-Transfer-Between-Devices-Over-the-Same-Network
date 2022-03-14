/*
 * Created by SharpDevelop.
 * Date: 2/11/2021
 * Time: 11:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace File_Transfer_TCP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_server = new System.Windows.Forms.Button();
			this.btn_client = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_server);
			this.groupBox1.Controls.Add(this.btn_client);
			this.groupBox1.Location = new System.Drawing.Point(12, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(318, 71);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Do you want to send or receive a file?";
			// 
			// btn_server
			// 
			this.btn_server.Location = new System.Drawing.Point(159, 29);
			this.btn_server.Name = "btn_server";
			this.btn_server.Size = new System.Drawing.Size(153, 26);
			this.btn_server.TabIndex = 1;
			this.btn_server.Text = "Receive";
			this.btn_server.UseVisualStyleBackColor = true;
			this.btn_server.Click += new System.EventHandler(this.Btn_serverClick);
			// 
			// btn_client
			// 
			this.btn_client.Location = new System.Drawing.Point(18, 29);
			this.btn_client.Name = "btn_client";
			this.btn_client.Size = new System.Drawing.Size(135, 26);
			this.btn_client.TabIndex = 0;
			this.btn_client.Text = "Send";
			this.btn_client.UseVisualStyleBackColor = true;
			this.btn_client.Click += new System.EventHandler(this.Btn_clientClick);
			// 
			// btn_exit
			// 
			this.btn_exit.Location = new System.Drawing.Point(255, 101);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(75, 23);
			this.btn_exit.TabIndex = 2;
			this.btn_exit.Text = "Exit";
			this.btn_exit.UseVisualStyleBackColor = true;
			this.btn_exit.Click += new System.EventHandler(this.Btn_exitClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 130);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "File Transfer Using TCP";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_client;
		private System.Windows.Forms.Button btn_server;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
