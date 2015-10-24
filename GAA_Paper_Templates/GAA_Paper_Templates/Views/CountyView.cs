using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAA_Paper_Templates.Common;

namespace GAA_Paper_Templates.Views
{
    class CountyView : ICountyView
    {
        GAA_Templates_ModelContainer context;
        public CountyView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public County CreateCounty(string name, Enums.Provinces province)
        {
            County c = new County();
            c.Name = name;
            c.Province = province.ToString();

            context.Counties.Add(c);
            context.SaveChanges();

            return c;
        }

        public County UpdateCounty(County county, string name, Enums.Provinces province)
        {
            County cty = context.Counties
                .Where(c => c == county)
                .FirstOrDefault();

            if (cty != null)
            {
                cty.Name = name;
                cty.Province = province.ToString();

                context.SaveChanges();

                return cty; 
            }
            else
            {
                return null;
            }
        }

        public County DeleteCounty(County county)
        {
            County cty = context.Counties
                .Where(c => c == county)
                .FirstOrDefault();

            if (cty != null)
            {
                context.Counties.Remove(cty);
                context.SaveChanges();

                return cty; 
            }
            else
            {
                return null;
            }
        }

        public List<County> GetAllCounties()
        {
            return context.Counties.ToList();
        }

        public List<County> GetCountiesByProvince(Enums.Provinces province)
        {
            return context.Counties
                .Where(c => c.Province == province.ToString())
                .ToList();
        }
    }
}
