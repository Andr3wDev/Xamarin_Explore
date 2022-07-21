using System;
using System.Collections.Generic;
using System.Text;

namespace Travel.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Place { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public string About { get; set; }
        public ICollection<LocationImage> Gallery { get; set; }
    }
}
