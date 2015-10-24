using System.Collections.Generic;

namespace GAA_Paper_Templates
{
    interface ICompetitionMatchTypeView
    {
        CompetitionMatchType CreateCompetitionMatchType(string name);
        CompetitionMatchType DeleteCompetitionMatchType(CompetitionMatchType matchType);
        List<CompetitionMatchType> GetAllCompetitionMatchTypes();
        List<CompetitionMatchType> GetCompetitionMatchTypesByCompetition(Competition comp);
        CompetitionMatchType UpdateCompetitionMatchType(CompetitionMatchType matchType, string name);
    }
}