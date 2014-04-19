using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands.Results {
    public class AudioDetailsArtist : AudioDetailsBase {
        public string Born { get; set; }
        public string Formed { get; set; }
        public string Died { get; set; }
        public string[] Style { get; set; }
        public string[] YearsActive { get; set; }
        public string[] Mood { get; set; }
        public string MusicBrainzArtistId { get; set; }
        public string Disbanded { get; set; }
        public string Description { get; set; }
        public string Artist { get; set; }
        public string[] Instrument { get; set; }
        public int ArtistId { get; set; }
    }
}
