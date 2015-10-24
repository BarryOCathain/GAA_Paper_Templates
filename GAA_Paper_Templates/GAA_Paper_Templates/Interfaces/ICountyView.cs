using System.Collections.Generic;
using GAA_Paper_Templates.Common;

namespace GAA_Paper_Templates.Interfaces
{
    public interface ICountyView
    {
        County CreateCounty(string name, Enums.Provinces province);
        County DeleteCounty(County county);
        List<County> GetAllCounties();
        List<County> GetCountiesByProvince(Enums.Provinces province);
        County UpdateCounty(County county, string name, Enums.Provinces province);
    }
}