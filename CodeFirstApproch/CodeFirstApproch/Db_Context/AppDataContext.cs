using CodeFirstApproch.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproch.Db_Context
{
    public class AppDataContext :DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options): base(options)
        {

        }
        public DbSet<StudentModel> students { get; set; }
    }
}
