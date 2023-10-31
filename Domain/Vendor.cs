using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Vendor
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Region { get; set; }

        public string Currency { get; set; }

        public string URL { get; set; }

        public ICollection<Price> Prices { get; } = new List<Price>(); 
    }
}