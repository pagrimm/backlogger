using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace Backlogger.Models
{
  public class  BackloggerContext : IdentityDbContext<ApplicationUser>
  {
    public BackloggerContext(DbContextOptions<BackloggerContext> options)
        : base(options)
    {
    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Show> Shows { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<MovieUser> MovieUser { get; set; }
    public DbSet<ShowUser> ShowUser { get; set; }
    public DbSet<GameUser> GameUser { get; set; }
    public DbSet<BookUser> BookUser { get; set; }

  }
}