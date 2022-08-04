using System;
using System.Collections.Generic;

/*
 * Escrito por Leonardo Schuber Perez
 * Desenvolvedor de Jogos & Softwares
 */

namespace LNetServer
{
    public interface IServer
    {
        string IPAddressValue { get; }
        int PortNumber { get; }
        Queue<string> MessageQueue { get; }
        void SendMessageToAll(LNetMessage.AMessage sendMessage);
        void SendMessageToAllButOne(LNetMessage.AMessage sendMessage, int ClientNumber);
        void SendMessageToOne(LNetMessage.AMessage sendMessage, int ClientNumber);
        void Start();
        void Stop();
    }
}
