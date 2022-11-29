using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {

        bool terminate = false;
        bool connected = false;
        string name;
        Socket clientSocket;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string IP = textBox_ip.Text;

            int portNum;
            if(Int32.TryParse(textBox_port.Text, out portNum))
            {
                try
                {
                    clientSocket.Connect(IP, portNum);
                    logs.AppendText("Connected to the server!\n");

                    this.name = textBox_name.Text;
                    if (this.name != "" && this.name.Length <= 64)
                    {
                        Byte[] buffer = Encoding.Default.GetBytes(this.name);
                        clientSocket.Send(buffer);
                    }
//If server rejects, do this;



                    button_connect.Enabled = false;
                    textBox_message.Enabled = true;
                    button_send.Enabled = true;
                    connected = true;

                    Thread receiveThread = new Thread(Receive);
                    receiveThread.Start();

                }
                catch
                {
                    logs.AppendText("Connection couldn't establish!\n");
                }
            }
            else
            {
                logs.AppendText("Port must be an integer value.\n");
            }

        }

        private void Receive()
        {
            while(connected)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    clientSocket.Receive(buffer);

                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));

                    logs.AppendText("Server: " + incomingMessage + "\n");
                }
                catch
                {
                    if (!terminate)
                    {
                        logs.AppendText("The server closed.\n\nGame Over!\n");
                        button_connect.Enabled = true;
                        textBox_message.Enabled = false;
                        button_send.Enabled = false;
                    }

                    clientSocket.Close();
                    connected = false;
                }

            }
        }


        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminate = true;
            Environment.Exit(0);
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;

            if(message != "" && message.Length <= 64)
            {
                Byte[] buffer = Encoding.Default.GetBytes(message);
                clientSocket.Send(buffer);
            }

        }
    }
}
