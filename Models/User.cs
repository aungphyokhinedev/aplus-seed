using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace aplus_back_seed.Models
{
    public class AplusContext : DbContext
    {
        
         public AplusContext(DbContextOptions<AplusContext> options) : base(options)  
        {  
            
        }  
        public DbSet<User>? users { get; set; }
       
      
    }

    public class User
    {

        [Key]
        public int UID { get; set; }
        public string? Mobile_no { get; set; }
    }

   
}