using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAA_Paper_Templates.Views
{
    class CompetitionMatchTypeView : ICompetitionMatchTypeView
    {
        GAA_Templates_ModelContainer context;
        public CompetitionMatchTypeView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public CompetitionMatchType CreateCompetitionMatchType(string name)
        {
            CompetitionMatchType c = new CompetitionMatchType();

            c.Name = name;

            context.CompetitionMatchTypes.Add(c);

            context.SaveChanges();

            return c;
        }

        public CompetitionMatchType UpdateCompetitionMatchType(CompetitionMatchType matchType, string name)
        {
            CompetitionMatchType cmt = context.CompetitionMatchTypes
                .Where(c => c == matchType)
                .FirstOrDefault();

            if (cmt != null)
            {
                cmt.Name = name;

                context.SaveChanges();

                return cmt; 
            }
            else
            {
                return null;
            }
        }

        public CompetitionMatchType DeleteCompetitionMatchType(CompetitionMatchType matchType)
        {
            CompetitionMatchType cmt = context.CompetitionMatchTypes
                .Where(c => c == matchType)
                .FirstOrDefault();

            if (cmt != null)
            {
                context.CompetitionMatchTypes.Remove(cmt);
                context.SaveChanges();

                return cmt;
            }
            else
            {
                return null;
            }
        }

        public List<CompetitionMatchType> GetAllCompetitionMatchTypes()
        {
            return context.CompetitionMatchTypes.ToList();
        }

        public List<CompetitionMatchType> GetCompetitionMatchTypesByCompetition(Competition comp)
        {
            return context.CompetitionMatchTypes
                .Where(c => c.Competitions == comp)
                .Distinct()
                .ToList();
        }
    }
}
