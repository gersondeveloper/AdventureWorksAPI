using AdventureWorks.API.AdventureWorks.Domain.PersonContext.Entities;
using System;
using System.Collections.Generic;

namespace AdventureWorks.API.AdventureWorks.Domain.SalesContext.Entities
{
    public partial class PersonCreditCard
    {
        public int BusinessEntityId { get; set; }
        public int CreditCardId { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Person BusinessEntity { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}
