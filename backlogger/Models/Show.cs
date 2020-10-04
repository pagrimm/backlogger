using System;
using System.Collections.Generic;

namespace Backlogger.Models
{
  public class Show
  {
    public Show()
    {
      this.Users = new HashSet<ShowUser>();
    }
    public int ShowId { get; set; }
    public ICollection<ShowUser> Users { get; set; }
  }
}