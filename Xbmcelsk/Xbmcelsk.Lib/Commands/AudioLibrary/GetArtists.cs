using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.Commands.AudioLibrary {
    class GetArtists : AbstractCommand<ArtistListReturn> {
        public bool? AlbumArtistsOnly { get; set; }
        public ListSort Sort { get; set; }
        public string Album { get; set; }
        public AudioFieldsArtist[] Properties { get; set; }

        protected override object BuildParameters() {
            return new {
                albumartistsonly = this.AlbumArtistsOnly,
                filter = new {
                    album = this.Album
                },
                properties = this.Properties,
            };
        }

        protected override string Method {
            get { return "AudioLibrary.GetArtists"; }
        }
    }
}
