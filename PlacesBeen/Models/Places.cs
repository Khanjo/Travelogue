using System.Collections.Generic;

namespace PlacesBeen.Models
{
    public class Place
    {
        public string City { get; set; }
        public string Country { get; set; }
        public string Journal { get; set; }
        public int Id { get; }
        private static List<Place> _instances = new List<Place> { };

        public Place(string city, string country, string journal)
        {
            City = city;
            Country = country;
            Journal = journal;
            _instances.Add(this);
            Id = _instances.Count;
        }
        public static List<Place> GetAll()
        {
            return _instances;
        }
        public static Place Find(int searchId)
        {
            return _instances[searchId - 1];
        }
        public static void Delete(int id)
        {
            _instances.RemoveAt(id - 1);
        }
    }
}