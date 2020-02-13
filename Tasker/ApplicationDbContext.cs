using System;
using Microsoft.EntityFrameworkCore;

namespace Tasker
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
