using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xbmcelsk.Lib.Commands.Results {
    public class ListSort {
        public ListSortOrder? Order { get; set; }
        public bool? IgnoreArticle { get; set; }
        public ListSortMethod Method { get; set; }

        public enum ListSortOrder {
            Ascending,
            Descending,
        }

        public enum ListSortMethod {
            None,
            Label,
            Date,
            Size,
            File,
            Path,
            DriveType,
            Title,
            Track,
            Time,
            Artist,
            Album,
            Albumtype,
            Genre,
            Country,
            Year,
            Rating,
            Votes,
            Top250,
            ProgramCount,
            Playlist,
            Episode,
            Season,
            TotalEpisodes,
            WatchedEpisodes,
            TvShowStatus,
            TvShowTitle,
            SortTitle,
            ProductionCode,
            Mpaa,
            Studio,
            DateAdded,
            LastPlayed,
            PlayCount,
            Listeners,
            Bitrate,
            Random
        }
    }
}
