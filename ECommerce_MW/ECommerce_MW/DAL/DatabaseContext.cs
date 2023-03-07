using ECommerce_MW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MW.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options ): base(options) //PERMITE UNA CONEXION A LA BASE DE DATOS
        {

        }  

        public DbSet<Country> Countries { get; set; }
    }
}
