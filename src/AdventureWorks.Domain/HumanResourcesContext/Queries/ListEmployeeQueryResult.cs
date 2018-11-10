using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.API.AdventureWorks.Domain.HumanResourcesContext.Queries
{
    public class ListEmployeeQueryResult
    {
        public int BusinessEntityID { get; private set; }
        public long NationalIDNumber { get; private set; }
        public string LoginID { get; private set; }
        public int OrganizationLevel { get; private set; }
        public string JobTitle { get; private set; }
    }
}
