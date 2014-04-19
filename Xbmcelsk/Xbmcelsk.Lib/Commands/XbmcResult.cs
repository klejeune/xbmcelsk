using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Xbmcelsk.Lib.Commands {
    class XbmcResult<TResult> {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }
        [JsonProperty("result")]
        public TResult Result { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
