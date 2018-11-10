using System;
using System.Collections.Generic;

namespace AdventureWorks.API.AdventureWorks.Domain.AdventureWorksContext.Models
{
    public partial class BusinessEntityContact
    {
        public int BusinessEntityId { get; set; }
        public int PersonId { get; set; }
        public int ContactTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public ContactType ContactType { get; set; }
        public Person Person { get; set; }
    }
}
