﻿using AdventureWorks.API.AdventureWorks.Domain.PersonContext.Entities;
using System;
using System.Collections.Generic;

namespace AdventureWorks.API.AdventureWorks.Domain.SalesContext.Entities
{
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
        }

        public int BusinessEntityId { get; set; }
        public string Name { get; set; }
        public int? SalesPersonId { get; set; }
        public string Demographics { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public ICollection<Customer> Customer { get; set; }
    }
}
