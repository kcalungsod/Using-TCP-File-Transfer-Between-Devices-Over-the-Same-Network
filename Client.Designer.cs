/*
 * Created by SharpDevelop.
 * Date: 2/11/2021
 * Time: 11:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace File_Transfer_TCP
{
	partial class Client
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
			this.txt_file = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_send = new System.Windows.Forms.Button();
			this.lbl_instructions = new System.Windows.Forms.Label();
			this.txt_port = new System.Windows.Forms.TextBox();
			this.txt_ipaddress = new System.Windows.Forms.TextBox();
			this.btn_browse = new System.Windows.Forms.Button();
			this.btn_back = new System.Windows.Forms.Button();
			this.lbl_status = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_file);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btn_send);
			this.groupBox1.Controls.Add(this.lbl_instructions);
			this.groupBox1.Controls.Add(this.txt_port);
			this.groupBox1.Controls.Add(this.txt_ipaddress);
			this.groupBox1.Controls.Add(this.btn_browse);
			this.groupBox1.Location = new System.Drawing.Point(13, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(337, 138);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Sending Files";
			// 
			// txt_file
			// 
			this.txt_file.Location = new System.Drawing.Point(7, 57);
			this.txt_file.Name = "txt_file";
			this.txt_file.Size = new System.Drawing.Size(243, 20);
			this.txt_file.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Port:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "IP address:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(256, 86);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(75, 23);
			this.btn_send.TabIndex = 5;
			this.btn_send.Text = "Send";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.Btn_sendClick);
			// 
			// lbl_instructions
			// 
			this.lbl_instructions.Location = new System.Drawing.Point(7, 20);
			this.lbl_instructions.Name = "lbl_instructions";
			this.lbl_instructions.Size = new System.Drawing.Size(311, 30);
			this.lbl_instructions.TabIndex = 4;
			this.lbl_instructions.Text = "Choose the file you want to send. Input the IP address and port number of the rec" +
			"eiver.";
			// 
			// txt_port
			// 
			this.txt_port.Location = new System.Drawing.Point(84, 112);
			this.txt_port.Name = "txt_port";
			this.txt_port.Size = new System.Drawing.Size(67, 20);
			this.txt_port.TabIndex = 3;
			// 
			// txt_ipaddress
			// 
			this.txt_ipaddress.Location = new System.Drawing.Point(84, 86);
			this.txt_ipaddress.Name = "txt_ipaddress";
			this.txt_ipaddress.Size = new System.Drawing.Size(166, 20);
			this.txt_ipaddress.TabIndex = 2;
			// 
			// btn_browse
			// 
			this.btn_browse.Location = new System.Drawing.Point(256, 57);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(75, 23);
			this.btn_browse.TabIndex = 1;
			this.btn_browse.Text = "Browse";
			this.btn_browse.UseVisualStyleBackColor = true;
			this.btn_browse.Click += new System.EventHandler(this.Btn_browseClick);
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(269, 159);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(75, 23);
			this.btn_back.TabIndex = 3;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.Btn_backClick);
			// 
			// lbl_status
			// 
			this.lbl_status.Location = new System.Drawing.Point(12, 148);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(231, 37);
			this.lbl_status.TabIndex = 5;
			this.lbl_status.Text = "Waiting for connection...";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 194);
			this.Controls.Add(this.lbl_status);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.groupBox1);
			this.Name = "Client";
			this.Text = "Client";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txt_file;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.TextBox txt_ipaddress;
		private System.Windows.Forms.TextBox txt_port;
		private System.Windows.Forms.Label lbl_instructions;
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_browse;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
