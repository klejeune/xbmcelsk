using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.Commands.Player {
    class GoTo : AbstractCommand<string> {
        public int PlayerId { get; set; }
        public PlayerGoToParameter To { get; set; }

        protected override object BuildParameters() {
            return new {
                playerid = this.PlayerId,
                to = this.To,
            };
        }

        protected override string Method {
            get { return "Player.GoTo"; }
        }
    }
}
