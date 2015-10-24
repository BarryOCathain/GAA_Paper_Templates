using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAA_Paper_Templates
{
    interface IPlayerView
    {
        Player CreatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam);
        Player UpdatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam);
        Player GetPlayerByFirstOrLastName(string firstName, string lastName);
        Player GetPlayerByClubAndFirstOrLastName(ClubTeam club, string firstName, string lastName);
        Player GetPlayerByCOuntyAndFirstOrLastName(CountyTeam county, string firstName, string lastName);
        List<Player> GetPlayersByClub(ClubTeam club);
        List<Player> GetPlayersByCounty(CountyTeam county);
        List<Player> GetPlayersByFirstName(string firstName);
        List<Player> GetPlayersByLastName(string lastName);
    }
}
