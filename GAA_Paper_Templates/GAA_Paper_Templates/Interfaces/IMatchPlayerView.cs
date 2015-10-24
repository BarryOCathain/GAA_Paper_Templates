using System.Collections.Generic;

namespace GAA_Paper_Templates.Interfaces
{
    public interface IMatchPlayerView
    {
        MatchPlayer CreateMatchPlayer(Player pl, Match match, int playerNumber);
        MatchPlayer DeleteMatchPlayer(MatchPlayer pl);
        List<MatchPlayer> GetMatchPlayersByTeamAndMatch(Team team, Match match);
        void SubPlayer(MatchPlayer playerOff, MatchPlayer playerOn, int minute);
        MatchPlayer UpdateMatchPlayer(MatchPlayer pl, int goals, int pens, int pts, int frees, int yellows, int blacks, int reds, bool sentOff, int minuteOff);
    }
}