using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.Commands.Player {
    class GetItem : AbstractCommand<ItemResult> {
        public int PlayerId { get; set; }

        protected override object BuildParameters() {
            return new {
                playerid = PlayerId,
            };
        }

        protected override string Method {
            get { return "Player.GetItem"; }
        }
    }
}
