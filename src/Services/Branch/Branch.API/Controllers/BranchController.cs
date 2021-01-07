using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Branch.API.Models;

namespace Branch.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchController : ControllerBase
    {
        // private static readonly string[] Summaries = new[]
        // {
        //     "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        // };

        private readonly ILogger<BranchController> _logger;

        public BranchController(ILogger<BranchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Branches> GetBranch(int id)
        {
            return new List<Branches>();
        }
    }
}
