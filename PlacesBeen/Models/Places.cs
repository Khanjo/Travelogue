using System.Collections.Generic;

namespace PlacesBeen.Models
{
    public class Place
    {
        public string Name { get; set; }
        public int Id { get; }
        private static List<Place> _instances = new List<Place> { };

        public Place(string name)
        {
            Name = name;
            _instances.Add(this);
            Id = _instances.Count;
        }
    }
}