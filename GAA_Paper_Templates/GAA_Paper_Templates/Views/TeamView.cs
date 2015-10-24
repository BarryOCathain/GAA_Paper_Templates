using System.Collections.Generic;
using System.Linq;
using GAA_Paper_Templates.Common;
using GAA_Paper_Templates.Interfaces;
using System;

namespace GAA_Paper_Templates.Views
{
    public class TeamView : ITeamView, IDisposable
    {
        GAA_Templates_ModelContainer context;
        private bool disposed = false;
        public TeamView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public Team CreateTeam(Enums.Classification classification, string name, string county)
        {
            County cty = context.Counties
                .Include("CountyTeam")
                .Where(c => c.Name == county)
                .FirstOrDefault();

            if (classification == Enums.Classification.Club)
            {
                ClubTeam t = new ClubTeam();
                t.Name = name;
                t.County = cty;

                context.Teams.Add(t);
                context.SaveChanges();

                return t;
            }
            else
            {
                CountyTeam t = new CountyTeam();
                t.Name = name;

                context.Teams.Add(t);
                context.SaveChanges();

                return t;
            }
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

        public ClubTeam GetClub(string name, County county)
        {
            ClubTeam output = null;

            List<Team> teams = context.Teams
                .Where(t => t.Name == name)
                .ToList();

            foreach (ClubTeam team in teams)
            {
                if (team.Name == name && team.County == county)
                {
                    output = team;
                }
            }

            return output;
        }

        public CountyTeam GetCountyTeam(string name)
        {
            return (CountyTeam)context.Teams
                .Where(t => t.Name == name)
                .FirstOrDefault();
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

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
            }

            disposed = true;
        }
    }
}
