using System.Collections.Generic;

namespace GAA_Paper_Templates.Interfaces
{
    public interface IVenueView
    {
        Venue CreateVenue(string name, string location, County county);
        Venue DeleteVenue(Venue venue);
        Venue GetVenue(string name);
        List<Venue> GetAllVenues();
        List<Venue> GetVenuesByCounty(County county);
        List<Venue> GetVenuesByLocation(string location);
        Venue UpdateVenue(Venue venue, string name, string location, County county);
    }
}