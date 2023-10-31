using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class Price
    {
        public Guid ProductsId { get; set; }

        public Guid VendorsId { get; set; }

        [Precision(18,2)]
        public decimal Amount { get; set; }

        public DateTime PriceTime { get; set; }
    }
}