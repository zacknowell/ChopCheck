using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Branch.API.Infrastructure.Repositories
{
    public class BranchRepository
    {
        private readonly IDatabase database;
        private readonly ILogger<BranchRepository> logger;

        public BranchRepository(ILogger logger, IDatabase database)
        {

        }
    }
}
