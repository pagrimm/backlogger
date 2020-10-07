using Backlogger.ApiModels;

namespace Backlogger.ViewModels
{
  public class ItemIndexPostViewModel
  {
    public RawgSearchRoot GamesSearch { get; set; } = null;
    public TmdbMovieSearchRoot MovieSearch { get; set; } = null;
    public TmdbTvSearchRoot TvSearch { get; set; } = null;
  }
}