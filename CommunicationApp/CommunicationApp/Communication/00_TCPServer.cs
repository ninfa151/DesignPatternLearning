using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp.Communication
{
    internal class TCPServer : BaseCommunication
    {
        private TcpListener _listener;
        internal TCPServer(IPAddress ip, int port)
        {
            try
            {
                _listener = new TcpListener(ip, port);
            }
            catch (Exception e)
            {
                //TODO logger
            }
        }
        internal override void prepareConnection()
        {
            throw new NotImplementedException();
        }
        internal override void makeConnection()
        {
            try
            {
                _listener.BeginAcceptTcpClient(new AsyncCallback(connectedCallback), _listener);
            }
            catch (Exception e)
            {
                //TODO logger
            }
        }
        internal override void closeConnection()
        {
            throw new NotImplementedException();
        }
        private void connectedCallback(IAsyncResult asyncResult)
        {
        }
    }
}
