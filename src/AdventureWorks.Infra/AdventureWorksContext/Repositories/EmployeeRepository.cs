using AdventureWorks.API.AdventureWorks.Domain.HumanResourcesContext.Entities;
using AdventureWorks.API.AdventureWorks.Domain.HumanResourcesContext.Queries;
using AdventureWorks.Domain.HumanResourcesContext.Repositories;
using AdventureWorks.Infra.AdventureWorksContext.DataContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureWorks.API.AdventureWorks.Infra.AdventureWorksContext.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AdventureWorksDBContext _context;

        public EmployeeRepository(AdventureWorksDBContext context)
        {
            _context = context;
        }

        public IEnumerable<ListEmployeeQueryResult> Get()
        {
            return
                _context
                .Connection
                .Query<ListEmployeeQueryResult>(
                    "ListGetAllEmployees",
                    commandType: System.Data.CommandType.StoredProcedure);
        }

        public void Save(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
