using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.Commands.Player {
    class GetProperties : AbstractCommand<PlayerPropertyValue> {
        public int PlayerId { get; set; }
        public PlayerPropertyName[] PropertyNames { get; set; }

        protected override object BuildParameters() {
            return new {
                playerid = PlayerId,
                properties = PropertyNames
            };
        }

        protected override string Method {
            get { return "Player.GetProperties"; }
        }
    }
}
