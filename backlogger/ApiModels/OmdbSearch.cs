using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Backlogger.Models;


namespace Backlogger.ApiModels
{
  public partial class OmdbSearchRoot
  {
    [JsonProperty("Search")]
    public List<OmdbSearchSearch> Search { get; set; }

    [JsonProperty("totalResults")]
    public string TotalResults { get; set; }

    [JsonProperty("Response")]
    public string Response { get; set; }
  }

  public partial class OmdbSearchSearch
  {
    [JsonProperty("Title")]
    public string Title { get; set; }

    [JsonProperty("Year")]
    public string Year { get; set; }

    [JsonProperty("imdbID")]
    public string ImdbId { get; set; }

    [JsonProperty("Type")]
    public string Type { get; set; }

    [JsonProperty("Poster")]
    public string Poster { get; set; }
  }
}