using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;

/*
 * Escrito por Leonardo Schuber Perez
 * Desenvolvedor de Jogos & Softwares
 */

namespace LNetServer
{
    public class CustomClient
    {
        public TcpClient tcpClient;
        public NetworkStream Stream;
        public Thread Thread;
        public int ClientNumber;
        public bool Connected;

        //+------------------------------------------------------------------+
        //| Custom                                                           |
        //+------------------------------------------------------------------+
        public string Nickname { get; set; }
        public string ClientVersion { get; set; }
        public int ClientID { get; set; }

        public CustomClient(TcpClient client, NetworkStream stream, int clientNumber)
        {
            this.tcpClient = client;
            this.Stream = stream;
            this.ClientNumber = clientNumber;
            this.Connected = true;
        }

        ~CustomClient()
        {
            Connected = false;
            tcpClient.Close();
            Stream.Close();
            Thread.Abort();
            Thread.Join();
        }
    }
}
