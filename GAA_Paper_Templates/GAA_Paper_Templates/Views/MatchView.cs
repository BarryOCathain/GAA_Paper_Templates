using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAA_Paper_Templates.Views
{
    class MatchView : IMatchView
    {
        GAA_Templates_ModelContainer context;
        public MatchView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public Match CreateMatch(DateTime matchDate, TimeSpan time, Venue venue, CompetitionMatchType matchType,
            Competition competition, Team homeTeam, Team awayTeam)
        {
            if (homeTeam.GetType() == awayTeam.GetType())
            {
                Match match = new Match();

                match.MatchDate = matchDate;
                match.MatchTime = time;
                match.Venue = venue;
                match.CompetitionMatchType = matchType;
                match.Competition = competition;
                match.HomeTeam = homeTeam;
                match.AwayTeam = awayTeam;

                context.Matches.Add(match);
                context.SaveChanges();

                return match; 
            }
            else
            {
                return null;
            }
        }

        public Match UpdateMatch(DateTime matchDate, TimeSpan time, Venue venue, CompetitionMatchType matchType,
            Competition competition, Team homeTeam, Team awayTeam)
        {
            if (homeTeam.GetType() == awayTeam.GetType())
            {
                Match match = context.Matches
                    .Where(m => m.MatchDate == matchDate && m.MatchTime == time && m.Venue == venue)
                    .FirstOrDefault();

                if (match != null)
                {
                    match.MatchDate = matchDate;
                    match.MatchTime = time;
                    match.Venue = venue;
                    match.CompetitionMatchType = matchType;
                    match.Competition = competition;
                    match.HomeTeam = homeTeam;
                    match.AwayTeam = awayTeam;

                    context.SaveChanges();

                    return match;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public Match DeleteMatch(DateTime MatchDate, TimeSpan time, Venue venue)
        {
            Match match = context.Matches
                .Where(m => m.MatchDate == MatchDate && m.MatchTime == time && m.Venue == venue)
                .FirstOrDefault();

            if (match != null)
            {
                context.Matches.Remove(match);

                return match; 
            }
            else
            {
                return null;
            }
        }

        public Match GetMatchByDateTimeAndVenue(DateTime matchDate, TimeSpan time, Venue venue)
        {
            return context.Matches
                .Where(m => m.MatchDate == matchDate && m.MatchTime == time && m.Venue == venue)
                .FirstOrDefault();
        }

        public List<Match> GetMatchesByDate(DateTime matchDate)
        {
            return context.Matches
                .Where(m => m.MatchDate == matchDate)
                .ToList();
        }

        public List<Match> GetMatchesByVenue(Venue venue)
        {
            return context.Matches
                .Where(m => m.Venue == venue)
                .ToList();
        }

        public List<Match> GetMatchesByTeam(Team team)
        {
            return context.Matches
                .Where(m => m.HomeTeam == team || m.AwayTeam == team)
                .ToList();
        }
    }
}
