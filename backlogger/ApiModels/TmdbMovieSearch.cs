using System.Collections.Generic;
using Newtonsoft.Json;

namespace Backlogger.ApiModels
{
  public partial class TmdbMovieSearchRoot
  {
    [JsonProperty("page")]
    public long Page { get; set; }

    [JsonProperty("total_results")]
    public long TotalResults { get; set; }

    [JsonProperty("total_pages")]
    public long TotalPages { get; set; }

    [JsonProperty("results")]
    public List<TmdbMovieSearchResult> Results { get; set; }
  }

  public partial class TmdbMovieSearchResult
  {
    [JsonProperty("popularity")]
    public double Popularity { get; set; }

    [JsonProperty("vote_count")]
    public long VoteCount { get; set; }

    [JsonProperty("video")]
    public bool Video { get; set; }

    [JsonProperty("poster_path")]
    public string PosterPath { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("adult")]
    public bool Adult { get; set; }

    [JsonProperty("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonProperty("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonProperty("original_title")]
    public string OriginalTitle { get; set; }

    [JsonProperty("genre_ids")]
    public List<long> GenreIds { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("vote_average")]
    public double VoteAverage { get; set; }

    [JsonProperty("overview")]
    public string Overview { get; set; }

    [JsonProperty("release_date")]
    public string ReleaseDate { get; set; }
  }
}