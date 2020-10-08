using System.Collections.Generic;
using Backlogger.ApiModels;

namespace Backlogger.ViewModels
{
  public class SearchListViewModel
  {
    public RawgSearchResult RawgSearchResult { get; set; }
    public TmdbMovieSearchResult TmdbMovieSearchResult { get; set; }

    public TmdbTvSearchResult TmdbTvSearchResult { get; set; }
    public List<long> ApiIds { get; set; }
  }
}