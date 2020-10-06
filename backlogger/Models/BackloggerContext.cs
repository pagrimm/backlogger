using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace Backlogger.Models
{
  public class  BackloggerContext : IdentityDbContext<ApplicationUser>
  {
    public BackloggerContext(DbContextOptions<BackloggerContext> options) : base(options) { }
    public DbSet<Item> Items { get; set; }
    public DbSet<ItemUser> ItemUser { get; set; }
  }
}