using System.Collections.Generic;

namespace GAA_Paper_Templates
{
    interface IVenueView
    {
        Venue CreateVenue(string name, string location, County county);
        Venue DeleteVenue(Venue venue);
        List<Venue> GetAllVenues();
        List<Venue> GetVenuesByCounty(County county);
        List<Venue> GetVenuesByLocation(string location);
        Venue UpdateVenue(Venue venue, string name, string location, County county);
    }
}