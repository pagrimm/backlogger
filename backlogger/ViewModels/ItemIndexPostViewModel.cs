using Backlogger.ApiModels;

namespace Backlogger.ViewModels
{
  public class ItemIndexPostViewModel
  {
    public RawgSearchRoot GamesSearch { get; set; } = null;
    public TmdbMovieSearchRoot MovieSearch { get; set; } = null;
    public TmdbTvSearchRoot TvSearch { get; set; } = null;
    public string searchOption { get; set; }
    public string searchString { get; set; }
    public int Pages { get; set; } = 1;
    public int CurrentPage { get; set; }
  }
}