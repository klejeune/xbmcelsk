using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands.Results {
    public class ArtistListReturn {
        public LimitsReturned Limits { get; set; }
        public AudioDetailsArtist[] Artists { get; set; }
    }
}
