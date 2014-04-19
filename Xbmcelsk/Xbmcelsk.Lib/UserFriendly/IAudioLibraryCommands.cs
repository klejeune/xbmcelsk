using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.UserFriendly {
    public interface IAudioLibraryCommands {
        ArtistListReturn GetArtists(ICredentials credentials, string albumName, AudioFieldsArtist[] properties);
        ArtistDetailsResult GetArtistDetails(ICredentials credentials, int artistId, AudioFieldsArtist[] properties);
    }
}
