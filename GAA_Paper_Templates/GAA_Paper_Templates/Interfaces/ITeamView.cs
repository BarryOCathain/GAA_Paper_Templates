using System.Collections.Generic;
using GAA_Paper_Templates.Common;

namespace GAA_Paper_Templates.Interfaces
{
    public interface ITeamView
    {
        Team CreateTeam(Enums.Classification classification, string name, string county);
        Team DeleteTeam(Team team);
        List<Team> GetAllTeams(Enums.Classification classification);
        List<ClubTeam> GetClubsByCounty(County county);
        Team UpdateTeam(Team team, string name);
        ClubTeam GetClub(string name, County county);
        CountyTeam GetCountyTeam(string name);
    }
}