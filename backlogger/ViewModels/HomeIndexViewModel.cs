using System.Collections.Generic;
using Backlogger.Models;

namespace Backlogger.ViewModels
{
  public class HomeIndexViewModel
  {
    public int TotalBacklog { get; set; }
    public int CompletedBacklog { get; set; }
    public int TotalGames { get; set; }
    public int CompletedGames { get; set; }
    public int TotalMovies { get; set; }
    public int CompletedMovies { get; set; }
    public int TotalTv { get; set; }
    public int CompletedTv { get; set; }
    public List<Item> RecentItems { get; set; }
  }
}