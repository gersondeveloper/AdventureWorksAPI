using AdventureWorks.API.AdventureWorks.Domain.ProductionContext.Entities;
using System;
using System.Collections.Generic;

namespace AdventureWorks.API.AdventureWorks.Domain.SalesContext.Entities
{
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            SalesOrderDetail = new HashSet<SalesOrderDetail>();
        }

        public int SpecialOfferId { get; set; }
        public int ProductId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Product Product { get; set; }
        public SpecialOffer SpecialOffer { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
    }
}
