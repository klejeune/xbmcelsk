using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xbmcelsk.Lib;
using Xbmcelsk.Lib.Commands.Results;

namespace Xbmcelsk.Tests {
    class Program {
        static void Main(string[] args) {
            var xbmc = new Xbmc();

            var credentials = xbmc.CreateCredentials("violette", 8080, "", "");

            //var players = xbmc.Player.GetActivePlayers(credentials);
            //var currentItem = xbmc.Player.GetItem(credentials, 0);
            //var property = xbmc.Player.GetProperties(credentials, 0, new[] { PlayerPropertyName.Position, });
            var property = xbmc.AudioLibrary.GetArtists(credentials, "Elegy", new[] { AudioFieldsArtist.Thumbnail, });
            //var property = xbmc.AudioLibrary.GetArtistDetails(credentials, 1003, new[] {AudioFieldsArtist.Thumbnail,});

        }
    }
}
