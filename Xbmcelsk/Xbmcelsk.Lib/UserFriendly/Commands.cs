using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.AudioLibrary;
using Xbmcelsk.Lib.Commands.Player;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.UserFriendly {
    internal class Commands : IPlayerCommands, IAudioLibraryCommands {
        public IEnumerable<Lib.Commands.Results.Player> GetActivePlayers(ICredentials credentials) {
            return new GetActivePlayers().Execute(credentials).Value;
        }

        public ItemResult GetItem(ICredentials credentials, int playerId) {
            return new GetItem {
                PlayerId = playerId,
            }
                .Execute(credentials)
                .Value;
        }

        public PlayerPropertyValue GetProperties(
            ICredentials credentials, int playerId, PlayerPropertyName[] propertyNames) {
            return new GetProperties {
                PlayerId = playerId,
                PropertyNames = propertyNames,
            }
                .Execute(credentials)
                .Value;
        }

        public string GoTo(ICredentials credentials, int playerId, PlayerGoToParameter to) {
            return new GoTo {
                PlayerId = playerId,
                To = to,
            }
                .Execute(credentials)
                .Value;
        }

        public string Move(ICredentials credentials, int playerId, PlayerMoveDirection direction) {
            return new Move {
                PlayerId = playerId,
                Direction = direction
            }
                .Execute(credentials)
                .Value;
        }

        public ArtistListReturn GetArtists(ICredentials credentials, string albumName, AudioFieldsArtist[] properties) {
            return new GetArtists {
                Album = albumName,
                Properties = properties,
            }
                .Execute(credentials)
                .Value;
        }

        public ArtistDetailsResult GetArtistDetails(ICredentials credentials, int artistId, AudioFieldsArtist[] properties) {
            return new GetArtistDetails {
                ArtistId = artistId,
                Properties = properties
            }
                .Execute(credentials)
                .Value;
        }
    }
}