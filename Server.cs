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
	//user interface where the server outputs the IP address and set port for the client to copy
	//server waits for connection from the client
	public partial class Server : Form
	{
		//gets the IP address of the device
	    private static string ipAddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
		private const int portNumber = 8080;
		
		/*once a file is received, class NewFileRecieved would be called*/ 		
		public delegate void FileRecievedEventHandler(object source, string fileName);

        public event FileRecievedEventHandler NewFileRecieved;
		
		public Server()
		{
			InitializeComponent();
		}
		
		void ServerLoad(object sender, EventArgs e)
		{
			lbl_ipaddress.Text = ipAddress;
			lbl_port.Text = portNumber.ToString();
			this.NewFileRecieved += new FileRecievedEventHandler(Server_NewFileRecieved);
		}
		
		 private void Server_NewFileRecieved(object sender, string fileName)
        {
		 /*used so that after the notice for the file being successfully received, program would
		open folder where that file went to check*/ 
            this.BeginInvoke(
            new Action(
            delegate()
            {
            	MessageBox.Show("Successfully received: \n" + fileName, "Notice");
                System.Diagnostics.Process.Start("explorer", txt_folderpath.Text);
            }));
        }

		void Btn_savetoClick(object sender, EventArgs e)
		{ //opens folderbrowserdialog so that user can specify where to save the file received
			using(var saveto = new FolderBrowserDialog())
			{
			    DialogResult result = saveto.ShowDialog();
			
			    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(saveto.SelectedPath))
			    {
			        string folder = saveto.SelectedPath;
					txt_folderpath.Text = folder;
			    }
			}				
		}
		  
		void Btn_stClick(object sender, EventArgs e)
		{
			//if the user didn't choose where the file received would be sent to, output an error message
			if (txt_folderpath.Text == ""){
					MessageBox.Show("Please follow the instructions and choose a folder to save the file to be received.","Warning");
				}
			else{
			//otherwise, start thread ReceiveTCP and transfer there the portNumber.
				Task.Factory.StartNew(() => ReceiveTCP(portNumber));
            	lbl_status.Text = "Server is Running...";
            //a "\" is added in the string for the folderpath so that saving can be done properly
            	txt_folderpath.Text = txt_folderpath.Text + "\\";
            	MessageBox.Show("Listening on port: " + portNumber, "Notice");
				}
			
		}
		
		public void ReceiveTCP(int port)
        {
            try
            {
            	/*opens TCPListener or advertises that the server is running and can be
				connected to by the client*/            	
            	TcpListener tcpListener = new TcpListener(IPAddress.Parse(ipAddress), port);
                tcpListener.Start();
                while (true)
                {	//automatically accepts connection from client, socket is formed for connection
                    Socket handlerSocket = tcpListener.AcceptSocket();
                    if (handlerSocket.Connected)
                    { //if socket is connected, receive the bytes sent by the client
                        string fileName = string.Empty;
                        NetworkStream networkStream = new NetworkStream(handlerSocket);
                        int thisRead = 0;
                        int blockSize = 1024; //1024 bytes = 1Mb
                        Byte[] dataByte = new Byte[blockSize];
                        //locked to ensure that one thread is executing a piece of code at one time.
                        lock (this)
                        {	//bytes are converted back to their previous format
                        	string folderPath = @txt_folderpath.Text;
                            handlerSocket.Receive(dataByte);
                            int fileNameLen = BitConverter.ToInt32(dataByte, 0);
                            fileName = Encoding.ASCII.GetString(dataByte, 4, fileNameLen);
                            //saving the file to the device using stream
                            Stream fileStream = File.OpenWrite(folderPath + fileName);
                            fileStream.Write(dataByte, 4 + fileNameLen, (1024 - (4 + fileNameLen)));
                            while (true)
                            {
                                thisRead = networkStream.Read(dataByte, 0, blockSize);
                                fileStream.Write(dataByte, 0, thisRead);
                                if (thisRead == 0)
                                    break;
                            }
                            fileStream.Close();
                        }
                        //once the file is received the NewFileReceived class above is called.
                        if (NewFileRecieved != null)
                        {
                            NewFileRecieved(this, fileName);
                        }
                        //closing socket
                       	handlerSocket = null;
                    }
                }
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    
                }                
            }
		
		void Btn_backClick(object sender, EventArgs e)
		{
			MainForm frm = new MainForm();
			frm.Show();
			this.Close();
		}
		
	}	
}
	
		

