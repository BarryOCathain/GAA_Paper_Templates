using GAA_Paper_Templates.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System;

namespace GAA_Paper_Templates.Views
{
    public class PlayerView : IPlayerView, IDisposable
    {
        private GAA_Templates_ModelContainer context;
        private bool disposed = false;
        public PlayerView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public Player CreatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam)
        {
            Player p = new Player();

            p.FirstName = firstName;
            p.LastName = lastName;
            p.IsObsolete = isObsolete;
            p.CountyTeam = countyTeam;
            p.ClubTeam = clubTeam;

            context.Players.Add(p);
            context.SaveChanges();

            return p;
        }

        public Player UpdatePlayer(string firstName, string lastName, bool isObsolete, CountyTeam countyTeam, ClubTeam clubTeam)
        {
            Player pl = context.Players
                .Where(p => p.FirstName == firstName && p.LastName == lastName)
                .FirstOrDefault();

            if (pl != null)
            {
                pl.FirstName = firstName;
                pl.LastName = lastName;
                pl.IsObsolete = isObsolete;
                pl.CountyTeam = countyTeam;
                pl.ClubTeam = clubTeam;

                context.SaveChanges();

                return pl; 
            }
            else
            {
                return null;
            }
        }

        public Player GetPlayerByFirstOrLastName(string firstName, string lastName)
        {
            if (firstName != null || lastName != null)
            {
                if (lastName == null)
                {
                    return context.Players
                        .Where(p => p.FirstName == firstName)
                        .FirstOrDefault();
                }
                else if (firstName == null)
                {
                    return context.Players
                        .Where(p => p.LastName == lastName)
                        .FirstOrDefault();
                }
                else
                {
                    return context.Players
                        .Where(p => p.FirstName == firstName && p.LastName == lastName)
                        .FirstOrDefault();
                }
            }
            else
            {
                return null;
            }
        }

        public Player GetPlayerByClubAndFirstOrLastName(ClubTeam club, string firstName, string lastName)
        {
            if (firstName != null || lastName != null)
            {
                if (lastName == null)
                {
                    return context.Players
                        .Where(p => p.ClubTeam == club && p.FirstName == firstName)
                        .FirstOrDefault();
                }
                else if (firstName == null)
                {
                    return context.Players
                        .Where(p => p.ClubTeam == club && p.LastName == lastName)
                        .FirstOrDefault();
                }
                else
                {
                    return context.Players
                        .Where(p => p.ClubTeam == club && p.FirstName == firstName && p.LastName == lastName)
                        .FirstOrDefault();
                }
            }
            else
            {
                return null;
            }
        }

        public Player GetPlayerByCOuntyAndFirstOrLastName(CountyTeam county, string firstName, string lastName)
        {
            if (firstName != null || lastName != null)
            {
                if (lastName == null)
                {
                    return context.Players
                        .Where(p => p.CountyTeam == county && p.FirstName == firstName)
                        .FirstOrDefault();
                }
                else if (firstName == null)
                {
                    return context.Players
                        .Where(p => p.CountyTeam == county && p.LastName == lastName)
                        .FirstOrDefault();
                }
                else
                {
                    return context.Players
                        .Where(p => p.CountyTeam == county && p.FirstName == firstName && p.LastName == lastName)
                        .FirstOrDefault();
                }
            }
            else
            {
                return null;
            }
        }

        public List<Player> GetPlayersByClub(ClubTeam club)
        {
            return context.Players
                .Where(p => p.ClubTeam == club)
                .ToList();
        }

        public List<Player> GetPlayersByCounty(CountyTeam county)
        {
            return context.Players
                .Where(p => p.CountyTeam == county)
                .ToList();
        }

        public List<Player> GetPlayersByFirstName(string firstName)
        {
            return context.Players
                .Where(p => p.FirstName == firstName)
                .ToList();
        }

        public List<Player> GetPlayersByLastName(string lastName)
        {
            return context.Players
                .Where(p => p.LastName == lastName)
                .ToList();
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
