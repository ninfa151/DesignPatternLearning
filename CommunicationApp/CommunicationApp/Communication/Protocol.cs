using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationApp.Communication
{
    internal abstract class Protocol
    {
        internal abstract void prepareConnection();
        internal abstract void makeConnection();
        internal abstract void closeConnection();
    }
}
