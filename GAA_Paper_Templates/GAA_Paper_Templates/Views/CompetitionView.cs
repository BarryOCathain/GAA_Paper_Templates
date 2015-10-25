using GAA_Paper_Templates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GAA_Paper_Templates.Views
{
    public class CompetitionView : ICompetitionView, IDisposable
    {
        GAA_Templates_ModelContainer context;
        private bool disposed = false;
        public CompetitionView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public Competition CreateCompetition(string name, DateTime startDate, DateTime endDate, County county)
        {
            Competition c = new Competition();

            c.Name = name;
            c.StartDate = startDate.Date;
            c.EndDate = endDate.Date;
            c.County = county;

            context.Competitions.Add(c);
            context.SaveChanges();

            return c;
        }

        public Competition UpdateCompetition(Competition comp, string name, DateTime startDate, DateTime endDate, County county)
        {
            Competition cmp = context.Competitions
                .Include("County")
                .Where(c => c.Name == comp.Name && c.StartDate == comp.StartDate && c.EndDate == comp.EndDate)
                .FirstOrDefault();

            if (cmp != null)
            {
                cmp.Name = name;
                cmp.StartDate = startDate.Date;
                cmp.EndDate = endDate.Date;
                cmp.County = county;

                context.SaveChanges();

                return cmp;
            }
            else
            {
                return null;
            }
        }

        public Competition DeleteCompetition(Competition comp)
        {
            Competition cmp = context.Competitions
                .Where(c => c == comp)
                .FirstOrDefault();

            if (cmp != null)
            {
                context.Competitions.Remove(cmp);
                context.SaveChanges();

                return cmp;
            }
            else
            {
                return null;
            }
        }

        public Competition GetCompetitionByNameYearAndCounty(string name, DateTime year, County county)
        {
            DateTime start = DateTime.Parse("01/01/" + year.Year);
            DateTime end = DateTime.Parse("31/12/" + year.Year);

            return context.Competitions
                .Where(c => c.Name == name && c.StartDate >= start && c.StartDate <= end)
                .FirstOrDefault();
                
        }

        public List<Competition> GetAllCompetitions()
        {
            return context.Competitions.ToList();
        }

        public List<Competition> GetCompetitionsByYear(DateTime year)
        {
            return context.Competitions
                .Where(c => c.StartDate == year)
                .ToList();
        }

        public List<Competition> GetCompetitionsByCountyAndYear(County county, DateTime year)
        {
            return context.Competitions
                .Where(c => c.County == county && c.StartDate == year)
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
