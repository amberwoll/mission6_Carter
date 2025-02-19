using Microsoft.EntityFrameworkCore;

namespace Mission6_Carter.Models;

public class MoviesContext : DbContext
{
    public MoviesContext(DbContextOptions<MoviesContext> options) : base(options) //Constructor
    {
        
    }
    
    public DbSet<Movie> Movies { get; set; } //db set of type applications, sets the table name
}