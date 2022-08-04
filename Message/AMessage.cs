using System;
using System.Runtime.Serialization;

/*
 * Escrito por Leonardo Schuber Perez
 * Desenvolvedor de Jogos & Softwares
 */


namespace LNetMessage
{
    [Serializable]
    public class AMessage
    {
        public AMessage(MessageType Type, int ID, string Message) { this.Type = Type; this.ID = ID; this.Message = Message; }
        public MessageType Type = MessageType.ANY;
        public int ID = 0;
        public string Message = "";
    }

    public enum MessageType
    {
        ANY,
        JOIN,
        LEAVE,
        INFO,
        INFOTO1,
        INFOEXCEPT1,
        ERROR,
        CLIENTCOUNT
    }
}