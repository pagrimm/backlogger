using System.Collections.Generic;
using Backlogger.ApiModels;

namespace Backlogger.ViewModels
{
  public class ItemDetailsViewModel
  {
    public RawgIdRoot GameDetails { get; set; } = null;
    public TmdbMovieRoot MovieDetails { get; set; } = null;
    public TmdbTvRoot TvDetails { get; set; } = null;
    public string ScreenShot { get; set; } = null;
    public List<long> ApiIds { get; set; }
  }
}