using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAA_Paper_Templates.Common;

namespace GAA_Paper_Templates.Views
{
    class TeamView : ITeamView
    {
        GAA_Templates_ModelContainer context;
        public TeamView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public Team CreateTeam(Enums.Classification classification, string name)
        {
            Team t;

            if (classification == Enums.Classification.Club)
            {
                t = new ClubTeam();
            }
            else
            {
                t = new CountyTeam();
            }

            t.Name = name;

            context.Teams.Add(t);
            context.SaveChanges();

            return t;
        }

        public Team UpdateTeam(Team team, string name)
        {
            if (name != null)
            {
                Team t = context.Teams
                    .Where(tm => tm == team)
                    .FirstOrDefault();

                t.Name = name;

                context.SaveChanges();

                return t;
            }
            else
            {
                return null;
            }
        }

        public Team DeleteTeam(Team team)
        {
            Team t = team;

            context.Teams.Remove(t);
            context.SaveChanges();

            return t;
        }

        public List<ClubTeam> GetClubsByCounty(County county)
        {
            List<ClubTeam> clubs = new List<ClubTeam>();

            List<Team> tempClubs = context.Teams
                .Where(t => t.GetType() == typeof(ClubTeam))
                .ToList();

            foreach (ClubTeam team in tempClubs)
            {
                if (team.County == county)
                {
                    clubs.Add(team);
                }
            }

            return clubs;
        }

        public List<Team> GetAllTeams(Enums.Classification classification)
        {
            List<Team> teams;
            Team type;

            if (classification == Enums.Classification.Club)
            {
                type = new ClubTeam();
            }
            else
            {
                type = new CountyTeam();
            }

            teams = context.Teams
                .Where(t => t.GetType() == type.GetType())
                .ToList();

            return teams;
        }
    }
}
