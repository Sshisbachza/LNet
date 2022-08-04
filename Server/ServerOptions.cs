using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LNetServer
{
    public class ServerOptions
    {
        public bool bIsCustomClient { get; set; }
        public bool bLogging { get; set; }

        public ServerOptions(bool CustomClient, bool Logging)
        {
            bIsCustomClient = CustomClient;
            bLogging = Logging;
        }
    }
}
