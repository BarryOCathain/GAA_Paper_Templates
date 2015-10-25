using System;
using System.Collections.Generic;

namespace GAA_Paper_Templates.Interfaces
{
    public interface ICompetitionView
    {
        Competition CreateCompetition(string name, DateTime startDate, DateTime endDate, County county);
        Competition DeleteCompetition(Competition comp);
        Competition GetCompetitionByNameYearAndCounty(string name, DateTime year, County county);
        List<Competition> GetAllCompetitions();
        List<Competition> GetCompetitionsByCountyAndYear(County county, DateTime year);
        List<Competition> GetCompetitionsByYear(DateTime year);
        Competition UpdateCompetition(Competition comp, string name, DateTime startDate, DateTime endDate, County county);
    }
}