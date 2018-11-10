using AdventureWorks.API.AdventureWorks.Domain.HumanResourcesContext.Entities;
using AdventureWorks.API.AdventureWorks.Domain.HumanResourcesContext.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.Domain.HumanResourcesContext.Repositories
{
    public interface IEmployeeRepository
    {
        void Save(Employee employee);
        IEnumerable<ListEmployeeQueryResult> Get();
    }
}
