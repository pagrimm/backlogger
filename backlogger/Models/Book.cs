using System;
using System.Collections.Generic;

namespace Backlogger.Models
{
  public class Book
  {
    public Book()
    {
      this.Users = new HashSet<BookUser>();
    }
    public int BookId { get; set; }
    public ICollection<BookUser> Users { get; set; }
  }
}