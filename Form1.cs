using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace project_server
{
    public class Player
    {
        public string Username { get; set; }
    }

    public partial class Form1 : Form
    {
        Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        List<Socket> client_sockets = new List<Socket>();
        Hashtable socket_player = new Hashtable();
        List<KeyValuePair<string, int>> question_answers = new List<KeyValuePair<string, int>>();

        bool listening = false;
        bool terminating = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.read_questions_answers();
        }


        private void read_questions_answers()
        {
            string[] lines = File.ReadAllLines("questions.txt");

            for (int i = 0; i < lines.Length; i+=2)
            {
                KeyValuePair<string, int> question_answer_pair = 
                    new KeyValuePair<string, int>(lines[i], Int32.Parse(lines[i+1]));

                this.question_answers.Add(question_answer_pair);
            }
        }

        private void listen_button_Click(object sender, EventArgs e)
        {
            int serverPort;

            if (Int32.TryParse(port_textBox.Text, out serverPort))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
                serverSocket.Bind(endPoint);
                serverSocket.Listen(2);

                listening = true;

                Thread acceptThread = new Thread(accept_connections);
                acceptThread.Start();

                this.logs_richTextBox.AppendText("Started listening on port: " + serverPort + "\n");

            }
            else
            {
                this.logs_richTextBox.AppendText("Please check port number \n");
            }
        }

        private void accept_connections()
        {
            while (listening)
            {
                try
                {
                    Socket newClient = serverSocket.Accept();
                    client_sockets.Add(newClient);

                    this.logs_richTextBox.AppendText("A client is connected.\n");

                    Thread receiveThread = new Thread(() => this.receive(newClient)); // updated
                    receiveThread.Start();
                }
                catch
                {
                    if (terminating)
                    {
                        listening = false;
                    }
                    else
                    {
                        this.logs_richTextBox.AppendText("The socket stopped working.\n");
                    }

                }
            }
        }

        private void receive(Socket thisClient) // updated
        {
            bool connected = true;

            while (connected && !terminating)
            {
                try
                {
                    Byte[] buffer = new Byte[64];
                    thisClient.Receive(buffer);

                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    this.logs_richTextBox.AppendText("Client: " + incomingMessage + "\n");
                }
                catch
                {
                    if (!terminating)
                    {
                        this.logs_richTextBox.AppendText("A client has disconnected\n");
                    }
                    thisClient.Close();
                    client_sockets.Remove(thisClient);
                    connected = false;
                }
            }
        }
    }
}