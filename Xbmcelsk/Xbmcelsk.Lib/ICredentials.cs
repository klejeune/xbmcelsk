using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib {
    public interface ICredentials {
        string Username { get; }
        string Password { get; }
        string Host { get; }
        int Port { get; }
    }
}
