/*
 * Created by SharpDevelop.
 * Date: 2/11/2021
 * Time: 11:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace File_Transfer_TCP
{
	partial class Server
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
			this.txt_folderpath = new System.Windows.Forms.TextBox();
			this.btn_saveto = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.lbl_port = new System.Windows.Forms.Label();
			this.lbl_ipaddress = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_st = new System.Windows.Forms.Button();
			this.lbl_status = new System.Windows.Forms.Label();
			this.btn_back = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_folderpath);
			this.groupBox1.Controls.Add(this.btn_saveto);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.lbl_port);
			this.groupBox1.Controls.Add(this.lbl_ipaddress);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(307, 163);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Receiving Files";
			// 
			// txt_folderpath
			// 
			this.txt_folderpath.Location = new System.Drawing.Point(93, 131);
			this.txt_folderpath.Name = "txt_folderpath";
			this.txt_folderpath.Size = new System.Drawing.Size(204, 20);
			this.txt_folderpath.TabIndex = 5;
			// 
			// btn_saveto
			// 
			this.btn_saveto.Location = new System.Drawing.Point(8, 131);
			this.btn_saveto.Name = "btn_saveto";
			this.btn_saveto.Size = new System.Drawing.Size(73, 23);
			this.btn_saveto.TabIndex = 6;
			this.btn_saveto.Text = "Save To:";
			this.btn_saveto.UseVisualStyleBackColor = true;
			this.btn_saveto.Click += new System.EventHandler(this.Btn_savetoClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 21);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(289, 47);
			this.label6.TabIndex = 4;
			this.label6.Text = "Copy the IP address and port below to the client application to establish connect" +
			"ion with the server. Choose where to save the file to be received before clickin" +
			"g start.";
			// 
			// lbl_port
			// 
			this.lbl_port.Location = new System.Drawing.Point(93, 101);
			this.lbl_port.Name = "lbl_port";
			this.lbl_port.Size = new System.Drawing.Size(159, 23);
			this.lbl_port.TabIndex = 3;
			// 
			// lbl_ipaddress
			// 
			this.lbl_ipaddress.Location = new System.Drawing.Point(93, 78);
			this.lbl_ipaddress.Name = "lbl_ipaddress";
			this.lbl_ipaddress.Size = new System.Drawing.Size(159, 23);
			this.lbl_ipaddress.TabIndex = 2;
			this.lbl_ipaddress.Click += new System.EventHandler(this.Lbl_ipaddressClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Port:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP Address:";
			// 
			// btn_st
			// 
			this.btn_st.Location = new System.Drawing.Point(247, 181);
			this.btn_st.Name = "btn_st";
			this.btn_st.Size = new System.Drawing.Size(73, 23);
			this.btn_st.TabIndex = 5;
			this.btn_st.Text = "Start";
			this.btn_st.UseVisualStyleBackColor = true;
			this.btn_st.Click += new System.EventHandler(this.Btn_stClick);
			// 
			// lbl_status
			// 
			this.lbl_status.Location = new System.Drawing.Point(36, 192);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(169, 31);
			this.lbl_status.TabIndex = 2;
			this.lbl_status.Text = "No connection...";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(247, 210);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(73, 23);
			this.btn_back.TabIndex = 4;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Click += new System.EventHandler(this.Btn_backClick);
			// 
			// Server
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 242);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.lbl_status);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_st);
			this.Name = "Server";
			this.Text = "Server";
			this.Load += new System.EventHandler(this.ServerLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_saveto;
		private System.Windows.Forms.TextBox txt_folderpath;
		private System.Windows.Forms.Button btn_st;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_port;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_ipaddress;
		private System.Windows.Forms.GroupBox groupBox1;
		
	
		void Lbl_ipaddressClick(object sender, System.EventArgs e)
		{
			
		}
	}
}
