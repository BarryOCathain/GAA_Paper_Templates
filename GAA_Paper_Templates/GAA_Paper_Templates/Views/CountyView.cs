using System.Collections.Generic;
using System.Linq;
using GAA_Paper_Templates.Common;
using GAA_Paper_Templates.Interfaces;
using System;

namespace GAA_Paper_Templates.Views
{
    public class CountyView : ICountyView, IDisposable
    {
        GAA_Templates_ModelContainer context;
        private bool disposed = false;
        public CountyView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public County CreateCounty(string name, Enums.Provinces province)
        {
            CountyTeam ct = new CountyTeam();
            ct.Name = name;

            County c = new County();
            c.Name = name;
            c.Province = province.ToString();
            c.CountyTeam = ct;

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

        public County GetCounty(string name)
        {
            return context.Counties
                .Where(c => c.Name == name)
                .FirstOrDefault();
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
