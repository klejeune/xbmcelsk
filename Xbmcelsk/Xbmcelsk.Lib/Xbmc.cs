using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Xbmcelsk.Lib.UserFriendly;

namespace Xbmcelsk.Lib {
    public class Xbmc {
        private readonly UserFriendly.Commands commands = new UserFriendly.Commands();

        public ICredentials CreateCredentials(string host, int port, string username, string password) {
            return new Credentials {
                Host = host,
                Port = port,
                Username = username,
                Password = password,
            };
        }

        public IPlayerCommands Player { get { return this.commands; } }
        public IAudioLibraryCommands AudioLibrary { get { return this.commands; } }
    }
}
