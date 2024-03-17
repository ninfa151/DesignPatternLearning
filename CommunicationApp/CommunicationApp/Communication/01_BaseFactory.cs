using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp.Communication
{
    internal abstract class BaseFactory
    {
        internal abstract BaseCommunication createCommunication(IPAddress address, int port);
    }
}
