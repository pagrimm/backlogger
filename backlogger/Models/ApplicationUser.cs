using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Backlogger.Models
{
  public class ApplicationUser : IdentityUser
  {
    public int PriorityValue { get; set; } = 1;
  }
}