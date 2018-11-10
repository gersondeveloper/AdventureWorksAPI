using AdventureWorks.API.AdventureWorks.Domain.HumanResourcesContext.Queries;
using AdventureWorks.Domain.HumanResourcesContext.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.API.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repository;

        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("v1/employees")]
        [ResponseCache(Duration = 15)]
        public IEnumerable<ListEmployeeQueryResult> Get()
        {
            return _repository.Get();
        }
    }
}
