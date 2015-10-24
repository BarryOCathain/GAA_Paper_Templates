using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAA_Paper_Templates.Views
{
    class MatchPlayerView : IMatchPlayerView
    {
        GAA_Templates_ModelContainer context;
        public MatchPlayerView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public MatchPlayer CreateMatchPlayer(Player pl, Match match, int playerNumber)
        {
            MatchPlayer mp = new MatchPlayer();

            mp.Player = pl;
            mp.Match = match;
            mp.PlayerNumber = playerNumber;
            mp.Goals = 0;
            mp.Penalties = 0;
            mp.Points = 0;
            mp.Frees = 0;
            mp.YellowCards = 0;
            mp.BlackCards = 0;
            mp.RedCards = 0;
            mp.IsSentOff = false;
            mp.IsSubbed = false;

            context.MatchPlayers.Add(mp);
            context.SaveChanges();

            return mp;
        }

        public MatchPlayer UpdateMatchPlayer(MatchPlayer pl, int goals, int pens, int pts, int frees, int yellows,
            int blacks, int reds, bool sentOff, int minuteOff)
        {
            MatchPlayer mp = context.MatchPlayers
                .Where(p => p == pl)
                .FirstOrDefault();

            if (mp != null)
            {
                mp.Goals = goals;
                mp.Penalties = pens;
                mp.Points = pts;
                mp.Frees = frees;
                mp.YellowCards = yellows;
                mp.BlackCards = blacks;
                mp.RedCards = reds;
                mp.IsSentOff = sentOff;
                mp.MinuteOff = minuteOff;

                context.SaveChanges();

                return mp;
            }
            else
            {
                return null;
            }
        }

        public MatchPlayer DeleteMatchPlayer(MatchPlayer pl)
        {
            MatchPlayer mp = context.MatchPlayers
                .Where(p => p == pl)
                .FirstOrDefault();

            if (mp != null)
            {
                context.MatchPlayers.Remove(mp);

                return mp;
            }
            else
            {
                return null;
            }
        }

        public List<MatchPlayer> GetMatchPlayersByTeamAndMatch(Team team, Match match)
        {
            return context.MatchPlayers
                .Where(m => m.Match == match && (m.Match.AwayTeam == team || m.Match.HomeTeam == team))
                .ToList();
        }

        public void SubPlayer(MatchPlayer playerOff, MatchPlayer playerOn, int minute)
        {
            MatchPlayer plOff = context.MatchPlayers
                .Where(m => m == playerOff)
                .FirstOrDefault();

            if (plOff != null)
            {
                plOff.IsSubbed = true;
                plOff.MinuteOff = minute;

                context.SaveChanges(); 
            }

            MatchPlayer plOn = context.MatchPlayers
                .Where(m => m == playerOn)
                .FirstOrDefault();

            if (plOn != null)
            {
                plOn.IsSubbed = true;
                plOn.MinuteOn = minute;

                context.SaveChanges(); 
            }
        }
    }
}
