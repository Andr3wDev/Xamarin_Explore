using System;
using System.Collections.Generic;
using System.Text;
using Travel.Interfaces;
using Travel.Models;

namespace Travel.Services
{
    /// <summary>
    /// Mock DB Service for demonstration
    /// </summary>
    public class MockDbService : IMockDbService
    {
        private List<LocationImage> GalleryItems;
        private List<Location> Recommended;
        private List<Location> Top;

        public MockDbService()
        {
            CreateGalleryItems();
            CreateRecommendedItems();
            CreateTopItems();
        }
        public void CreateGalleryItems()
        {
            GalleryItems = new List<LocationImage>
            {
                new LocationImage { Id = 1, Image = "destination1.jpg" },
                new LocationImage { Id = 2, Image = "destination2.jpg" },
                new LocationImage { Id = 3, Image = "destination3.jpg" },
                new LocationImage { Id = 4, Image = "destination4.jpg" }
            };
        }
        public void CreateRecommendedItems()
        {
            Recommended = new List<Location>
            {
                new Location { Name = "Japan Temple", Place = "Osaka Street, Japan", Image = "destination1.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = GalleryItems },
                new Location { Name = "Torii Gate", Place = "Tokyo Street, Japan", Image = "destination2.jpg", Price = 90, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = GalleryItems },
                new Location { Name = "Japan Street", Place = "Japan", Image = "destination3.jpg", Price = 60, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = GalleryItems },
                new Location { Name = "Japan Street", Place = "Japan", Image = "destination4.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.", Gallery = GalleryItems },
            };
        }
        public void CreateTopItems()
        {
            Top = new List<Location>
            {
                new Location { Name = "Japan Street", Place = "Japan", Image = "destination3.jpg", Price = 60, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.",  Gallery = GalleryItems },
                new Location { Name = "Japan Street", Place = "Japan", Image = "destination4.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.",  Gallery = GalleryItems },
                new Location { Name = "Japan Temple", Place = "Osaka Street, Japan", Image = "destination1.jpg", Price = 120, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.",  Gallery = GalleryItems },
                new Location { Name = "Torii Gate", Place = "Tokyo Street, Japan", Image = "destination2.jpg", Price = 90, About = "Modern destination, with sky landspace, Simple Building, and perfect for photos.",  Gallery = GalleryItems },
            };
        }

        public List<LocationImage> GetGalleryItems()
        {
            return GalleryItems;
        }

        public List<Location> GetRecommendedItems()
        {
            return Recommended;
        }

        public List<Location> GetTopItems()
        {
            return Top;
        }
    }
}