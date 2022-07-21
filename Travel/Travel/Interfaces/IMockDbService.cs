using System.Collections.Generic;
using Travel.Models;

namespace Travel.Interfaces
{
    public interface IMockDbService
    {
        List<LocationImage> GetGalleryItems();
        List<Location> GetRecommendedItems();
        List<Location> GetTopItems();
        void CreateGalleryItems();
        void CreateRecommendedItems();
        void CreateTopItems();
    }
}
