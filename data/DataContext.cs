using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding.data
{
    class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataContext() : base("Server=(localdb)\\mssqllocaldb;Database = codingDB; Trusted_Connection=True")
        {

        }
    }
}
