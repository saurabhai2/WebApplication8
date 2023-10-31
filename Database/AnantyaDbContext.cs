using System.Data.Entity;
using WebApplication8.Models;

namespace WebApplication8.Database
{
    public class AnantyaDbContext :DbContext
    {
        public AnantyaDbContext() : base("Myconn")
        {

        }
        public DbSet<Register> Register { get; set; }

        public DbSet<Login> login { get; set; }

        public DbSet<Tittle> Tittle { get; set; }



    }
}
