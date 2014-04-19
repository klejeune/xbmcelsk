using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands {
    interface ICommand<TResult> {
        IResult<TResult> Execute(ICredentials credentials);
    }
}
