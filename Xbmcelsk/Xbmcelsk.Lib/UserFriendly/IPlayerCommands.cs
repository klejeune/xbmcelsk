using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Lib.UserFriendly {
    public interface IPlayerCommands {
        IEnumerable<Player> GetActivePlayers(ICredentials credentials);
        ItemResult GetItem(ICredentials credentials, int playerId);
        PlayerPropertyValue GetProperties(ICredentials credentials, int playerId, PlayerPropertyName[] propertyNames);
        string GoTo(ICredentials credentials, int playerId, PlayerGoToParameter to);
        string Move(ICredentials credentials, int playerId, PlayerMoveDirection direction);
    }
}
