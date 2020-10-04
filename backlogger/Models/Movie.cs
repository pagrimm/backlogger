using System;
using System.Collections.Generic;

namespace Backlogger.Models
{
  public class Movie
  {
    public Movie()
    {
      this.Users = new HashSet<MovieUser>();
    }
    public int MovieId { get; set; }
    public ICollection<MovieUser> Users { get; set; }
  }
}