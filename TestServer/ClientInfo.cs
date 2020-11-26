﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestServer
{
    class ClientInfo
    {
        public Socket ClientSocket { get; set; }
        public String RemoteEndPoint { get; set; }

        public override string ToString()
        {
            return RemoteEndPoint;
        }
    }
}
