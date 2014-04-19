using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands {
    class Result<T> : IResult<T> {
        public T Value {
            get; set;
        }

        public string Raw {
            get; set;
        }

        public IError Error {
            get; set;
        }
    }
}
