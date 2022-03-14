using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Transfer_TCP
{
	//user interface where the client inputs the IP address and set port of the receiver to send files.
	public partial class Client : Form
	{
        
        private static string shortfileName = "";
        
		public Client()
		{
			InitializeComponent();
		}
		
		void Btn_backClick(object sender, EventArgs e)
		{
			MainForm frm = new MainForm();
			frm.Show();
			this.Close();
		}
		
		void Btn_browseClick(object sender, EventArgs e)
		{ // opens an open file dialog so user can choose what file to send to the server
			OpenFileDialog openfile = new OpenFileDialog();
			openfile.Title = "File Sharing - Client";
			openfile.ShowDialog();
			txt_file.Text = openfile.FileName;
			shortfileName = openfile.SafeFileName; //to fetch the filename of the file without the path
		}
		
			void Btn_sendClick(object sender, EventArgs e)
		{
				string IP = txt_ipaddress.Text;
				string fileName = txt_file.Text;
				int port = int.Parse(txt_port.Text);
            	
				//checks if all the textboxes are empty or not
				if (txt_file.Text == "" || txt_ipaddress.Text == "" || txt_port.Text == "")
            	{   
					MessageBox.Show("Please follow the instructions and fill in all the textboxes. ","Warning");
            		}
				else {  //calls the class SendTCP
                Task.Factory.StartNew(() => SendTCP(IP, port, fileName, shortfileName));
	            lbl_status.Text = "Connected to the server.";
                MessageBox.Show("Succcessfully sent: \n" + shortfileName, "Notice");
				}
			}
			
			
			public void SendTCP(string remotehostIP, int Port, string filepath, string filename)
        	{
	            try
	            {
	                if (!string.IsNullOrEmpty(remotehostIP))
	                {
	                	//filepath and filename are converted to bytes.
	                	//both are then copied into one byte variable - ClientData.
	                byte[] fileNameByte = Encoding.ASCII.GetBytes(filename);
	                byte[] fileData = File.ReadAllBytes(filepath);
	                byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
	                byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);
	                fileNameLen.CopyTo(clientData, 0);
	                fileNameByte.CopyTo(clientData, 4);
	                fileData.CopyTo(clientData, 4 + fileNameByte.Length);
	                	//opens client socket; finds the server
	                	//once the server is found, write or send the data
	                TcpClient clientSocket = new TcpClient(remotehostIP, Port);
	                NetworkStream networkStream = clientSocket.GetStream();
	                networkStream.Write(clientData, 0, clientData.GetLength(0));
	                	//close
	                networkStream.Close();
	                }
	            }
	            catch (SocketException e)
	            {
	                MessageBox.Show(e.Message);
	            }
	            catch (ArgumentNullException e)
			  	{
			    	MessageBox.Show(e.Message);
			  	}		
			}
		}
	}

