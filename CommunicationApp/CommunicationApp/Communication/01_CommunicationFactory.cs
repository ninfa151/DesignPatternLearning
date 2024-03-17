using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp.Communication
{
    internal class CommunicationFactory : BaseFactory
    {
        internal override BaseCommunication createCommunication(IPAddress address, int port)
        {
            return new TCPServer(address, port);
        }
    }
}
