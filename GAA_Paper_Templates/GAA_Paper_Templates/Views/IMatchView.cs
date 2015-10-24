using System;
using System.Collections.Generic;

namespace GAA_Paper_Templates
{
    interface IMatchView
    {
        Match AddMatch(DateTime matchDate, TimeSpan time, Venue venue, CompetitionMatchType matchType, Competition competition, Team homeTeam, Team awayTeam);
        Match DeleteMatch(DateTime MatchDate, TimeSpan time, Venue venue);
        Match GetMatchByDateTimeAndVenue(DateTime matchDate, TimeSpan time, Venue venue);
        List<Match> GetMatchesByDate(DateTime matchDate);
        List<Match> GetMatchesByVenue(Venue venue);
        Match UpdateMatch(DateTime matchDate, TimeSpan time, Venue venue, CompetitionMatchType matchType, Competition competition, Team homeTeam, Team awayTeam);
    }
}