using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAA_Paper_Templates.Views
{
    class CompetitionView : ICompetitionView
    {
        GAA_Templates_ModelContainer context;
        public CompetitionView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public Competition CreateCompetition(string name, DateTime startDate, DateTime endDate)
        {
            Competition c = new Competition();

            c.Name = name;
            c.StartDate = startDate;
            c.EndDate = endDate;

            context.Competitions.Add(c);
            context.SaveChanges();

            return c;
        }

        public Competition UpdateCompetition(Competition comp, string name, DateTime startDate, DateTime endDate)
        {
            Competition cmp = context.Competitions
                .Where(c => c == comp)
                .FirstOrDefault();

            if (cmp != null)
            {
                cmp.Name = name;
                cmp.StartDate = startDate;
                cmp.EndDate = endDate;

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
    }
}
