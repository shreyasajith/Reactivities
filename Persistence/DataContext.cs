using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Domain;
using Activity = Domain.Activity;

namespace Persistence
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {

        }
               
        public DbSet<Activity> Activities { get; set; }
    }
}
