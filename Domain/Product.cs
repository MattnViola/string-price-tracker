using System.Collections.ObjectModel;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Instrument { get; set; }

        public ICollection<Price> Prices { get; } = new List<Price>(); 
    }
}