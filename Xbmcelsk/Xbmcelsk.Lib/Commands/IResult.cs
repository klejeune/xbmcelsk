using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands {
    interface IResult<TResult> {
        TResult Value { get; }
        string Raw { get; }
        IError Error { get; }
    }
}
