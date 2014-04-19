using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands.Results {
    public class PlayerPropertyValue {
        public bool CanRepeat { get; set; }
        public bool CanMove{ get; set; }
        public bool CanShuffle { get; set; }
        public int Speed { get; set; }
        public int Percentage { get; set; }
        public int PlaylistId { get; set; }
        public PlayerAudioStream[] AudioStreams { get; set; }
        public int Position { get; set; }
        public PlayerRepeat Repeat { get; set; }
        public PlayerSubtitle CurrentSubtitle { get; set; }
        public bool CanRotate{ get; set; }
        public bool CanZoom { get; set; }
        public bool CanChangeSpeed { get; set; }
        public PlayerType Type { get; set; }
        public bool PartyMode { get; set; }
        public PlayerSubtitle[] Subtitles { get; set; }
        public bool CanSeek { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan TotalTime { get; set; }
        public bool Shuffled { get; set; }
        public PlayerAudioStreamExtended CurrentAudioStream { get; set; }
        public bool Live { get; set; }
        public bool SubtitleEnabled { get; set; }
    }
}
