using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Xbmcelsk.Lib.Commands {
    abstract class AbstractCommand<TResult> : ICommand<TResult> {
        private Random random = new Random();
      

        public IResult<TResult> Execute(ICredentials credentials) {
            var parameters = this.BuildParameters();

            string json = JsonConvert.SerializeObject(
                new {
                    jsonrpc = "2.0",
                    method = this.Method,
                    id = this.random.Next(),
                    @params = parameters,
                },
                Formatting.None,
                Serializer.Settings);

            var url = string.Format("http://{0}:{1}/jsonrpc?request={2}", credentials.Host, credentials.Port, json);
            var request = WebRequest.Create(url);

            if (!string.IsNullOrEmpty(credentials.Username)) {
                request.Credentials = new NetworkCredential(credentials.Username, credentials.Password);
            }

            var response = request.GetResponse();

            string responseResult;

            using (var reader = new StreamReader(response.GetResponseStream())) {
                responseResult = reader.ReadToEnd();
            }

            var result = new Result<TResult> {
                Value = JsonConvert.DeserializeObject<XbmcResult<TResult>>(responseResult).Result,
                Raw = responseResult,
                Error = null,
            };

            return result;
        }

        protected abstract object BuildParameters();

        protected abstract string Method { get; }
    }
}
