using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.Commands.AudioLibrary {
    class GetArtistDetails : AbstractCommand<ArtistDetailsResult> {
        public int ArtistId { get; set; }
        public AudioFieldsArtist[] Properties { get; set; }

        protected override object BuildParameters() {
            return new {
                artistid = this.ArtistId,
                properties = this.Properties
            };
        }

        protected override string Method {
            get { return "AudioLibrary.GetArtistDetails"; }
        }
    }
}
