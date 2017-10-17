using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Socket;
using System.Net;

namespace multisocket
{
    public partial class Form1 : Form
    {
        SocketManager Socket = new SocketManager(2048, 000);

        public int client = 0;

        public string text_ip = "127.0.0.1";


        public Form1()
        {
            InitializeComponent();
            Socket.ClientConnected += Socket_CliendConnected;
            Socket.ClientDissconnected += Socket_ClientDisconnected;
            Socket.ConnectedServer += Socket_ConnectedServer;
            Socket.HostLost += Socket_HostLost;
            Socket.HostRefused += Socket_HostRefused;
            Socket.ReceivedMessage += Socket_ReceivedMessage;

        }


        void EnterLog(string ms)
        {
            richTextBox1.Text += ms + "\n";

        }
        private void Socket_ReceivedMessage(string Message, TcpClient FromClient)
        {
            EnterLog(Message);
        }

        private void Socket_HostRefused()
        {
            EnterLog("Serverdan atıldınız..");
        }

        private void Socket_HostLost()
        {
            EnterLog("Server kapanmıştır...");
        }

        private void Socket_ConnectedServer()
        {
            EnterLog("Servera giriş yaptınız...");
        }

        private void Socket_ClientDisconnected(TcpClient Client)
        {
            EnterLog("Serverdan kullanıcı ayrıldı.");
        }

        private void Socket_CliendConnected(TcpClient Client)
        {
            EnterLog("Servera kullanıcı katıldı.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Socket.Stop();
        }

        private void btn_dc_Click(object sender, EventArgs e)
        {
            Socket.Dissconnect();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            client = Int32.Parse(client_al.Text);
            if (Socket._isHost)
            {
                if (nthclient.Checked)
                {
                    label5.Text = Socket._clients.Length.ToString();
                    Socket.SendMessageToAClient(text_name.Text + " : " + text_msg.Text, Socket._clients[client - 1]);
                }
                else
                {
                    Socket.SendMessageToAllClients(text_name.Text + " : " + text_msg.Text);
                }
            }
            else
            {

                if (nthclient.Checked)
                {
                    Socket.SendMessageToAClient(text_name.Text + " : " + text_msg.Text, Socket._clients[client - 1]);
                }
                if (hostonly.Checked)
                {
                    Socket.SendMessageToHost(text_name.Text + " : " + text_msg.Text);
                }
                else
                {
                    Socket.SendMessageToHostAndAllClients(text_name.Text + " : " + text_msg.Text);
                }
            }



            EnterLog(text_name.Text + " : " + text_msg.Text);
            text_msg.Text = "";
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Socket.Port = Convert.ToInt32(text_port.Text);
            Socket.Connect(text_ip);
            Socket.StartLisenClients();
        }

        private void btn_host_Click(object sender, EventArgs e)
        {
            Socket.Port = Convert.ToInt32(text_port.Text);
            Socket.Host();
            Socket.StartLisenClients();
        }

    }
}
