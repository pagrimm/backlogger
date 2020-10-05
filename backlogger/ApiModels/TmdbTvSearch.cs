using System.Collections.Generic;
using Newtonsoft.Json;

namespace Backlogger.ApiModels
{
  public partial class TmdbTvSearchRoot
  {
    [JsonProperty("page")]
    public long Page { get; set; }

    [JsonProperty("total_results")]
    public long TotalResults { get; set; }

    [JsonProperty("total_pages")]
    public long TotalPages { get; set; }

    [JsonProperty("results")]
    public List<TmdbTvSearchResult> Results { get; set; }
  }

  public partial class TmdbTvSearchResult
  {
    [JsonProperty("original_name")]
    public string OriginalName { get; set; }

    [JsonProperty("genre_ids")]
    public List<long> GenreIds { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("popularity")]
    public double Popularity { get; set; }

    [JsonProperty("origin_country")]
    public List<string> OriginCountry { get; set; }

    [JsonProperty("vote_count")]
    public long VoteCount { get; set; }

    [JsonProperty("first_air_date")]
    public string FirstAirDate { get; set; }

    [JsonProperty("backdrop_path")]
    public string BackdropPath { get; set; }

    [JsonProperty("original_language")]
    public string OriginalLanguage { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("vote_average")]
    public double VoteAverage { get; set; }

    [JsonProperty("overview")]
    public string Overview { get; set; }

    [JsonProperty("poster_path")]
    public string PosterPath { get; set; }
  }
}