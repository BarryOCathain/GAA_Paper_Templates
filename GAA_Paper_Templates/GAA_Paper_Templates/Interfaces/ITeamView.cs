using System.Collections.Generic;
using GAA_Paper_Templates.Common;

namespace GAA_Paper_Templates
{
    interface ITeamView
    {
        Team CreateTeam(Enums.Classification classification, string name);
        Team DeleteTeam(Team team);
        List<Team> GetAllTeams(Enums.Classification classification);
        List<ClubTeam> GetClubsByCounty(County county);
        Team UpdateTeam(Team team, string name);
    }
}