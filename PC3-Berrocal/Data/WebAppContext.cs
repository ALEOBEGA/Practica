using PC3_Berrocal.Models;
using Microsoft.EntityFrameworkCore;


namespace PC3_Berrocal.Data{
    public class WebAppContext: DbContext
    {
        public DbSet<Producto> productos{get;set;}
        public WebAppContext(DbContextOptions dco): base(dco){
            
        }
    }
}