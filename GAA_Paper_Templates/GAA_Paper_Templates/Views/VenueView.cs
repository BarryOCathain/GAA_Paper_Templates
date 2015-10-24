using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAA_Paper_Templates.Views
{
    class VenueView : IVenueView
    {
        GAA_Templates_ModelContainer context;
        public VenueView(GAA_Templates_ModelContainer _context)
        {
            context = _context;
        }

        public Venue CreateVenue(string name, string location, County county)
        {
            Venue ven = new Venue();

            ven.Name = name;
            ven.Location = location;
            ven.County = county;

            context.Venues.Add(ven);
            context.SaveChanges();

            return ven;
        }

        public Venue UpdateVenue(Venue venue, string name, string location, County county)
        {
            Venue ven = context.Venues
                .Where(v => v == venue)
                .FirstOrDefault();

            if (ven != null)
            {
                ven.Name = name;
                ven.Location = location;
                ven.County = county;

                context.SaveChanges();

                return ven; 
            }
            else
            {
                return null;
            }
        }

        public Venue DeleteVenue(Venue venue)
        {
            Venue ven = context.Venues
                .Where(v => v == venue)
                .FirstOrDefault();

            if (ven != null)
            {
                context.Venues.Remove(ven);
                context.SaveChanges();

                return ven;  
            }
            else
            {
                return null;
            }
        }

        public List<Venue> GetAllVenues()
        {
            return context.Venues.ToList();
        }

        public List<Venue> GetVenuesByCounty(County county)
        {
            return context.Venues
                .Where(v => v.County == county)
                .ToList();
        }

        public List<Venue> GetVenuesByLocation(string location)
        {
            return context.Venues
                .Where(v => v.Location == location)
                .ToList();
        }
    }
}
