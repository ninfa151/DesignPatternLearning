using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp.Communication
{
    internal class TCPServer : Protocol
    {
        private TcpListener _listener;
        internal TCPServer(IPAddress ip, int port)
        {
            _listener = new TcpListener(ip, port);
        }
        internal override void prepareConnection()
        {
            throw new NotImplementedException();
        }
        internal override void makeConnection()
        {
            throw new NotImplementedException();
        }
        internal override void closeConnection()
        {
            throw new NotImplementedException();
        }
    }
}
