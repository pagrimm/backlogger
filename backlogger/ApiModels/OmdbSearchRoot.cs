using System.Collections.Generic;

namespace Backlogger.Models
{
  public class OmdbSearchRoot
  {
    public int totalResults { get; set; } = 0;
    public List<OmdbSearchSearch> Search { get; set; } 
  }
}