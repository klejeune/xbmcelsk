using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands.Player {
    class GetActivePlayers : AbstractCommand<Results.Player[]> {
        protected override object BuildParameters() {
            return new {
            };
        }



        protected override string Method {
            get { return "Player.GetActivePlayers"; }
        }
    }
}
