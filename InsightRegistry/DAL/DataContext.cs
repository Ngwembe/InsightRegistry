using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InsightRegistry.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InsightRegistry.DAL
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IConfiguration _configuration;
        
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration)
         : base(options)
        {
            _configuration = configuration;
        }
    }
}
