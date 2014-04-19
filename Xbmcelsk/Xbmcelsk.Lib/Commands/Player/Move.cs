using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.Commands.Player {
    class Move : AbstractCommand<string> {
        public int PlayerId { get; set; }
        public PlayerMoveDirection Direction { get; set; }

        protected override object BuildParameters() {
            return new {
                playerid = this.PlayerId,
                direction = this.Direction
            };
        }

        protected override string Method {
            get { return "Player.Move"; }
        }
    }
}
