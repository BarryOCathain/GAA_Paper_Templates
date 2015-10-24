using System;
using System.Collections.Generic;

namespace GAA_Paper_Templates.Interfaces
{
    public interface ICompetitionView
    {
        Competition CreateCompetition(string name, DateTime startDate, DateTime endDate);
        Competition DeleteCompetition(Competition comp);
        List<Competition> GetAllCompetitions();
        List<Competition> GetCompetitionsByCountyAndYear(County county, DateTime year);
        List<Competition> GetCompetitionsByYear(DateTime year);
        Competition UpdateCompetition(Competition comp, string name, DateTime startDate, DateTime endDate);
    }
}