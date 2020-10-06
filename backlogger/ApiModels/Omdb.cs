using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Backlogger.Models;

namespace Backlogger.ApiModels
{
  public class Omdb
  {
    public static OmdbIdRoot GetMovieById(string id)
    {
      var apiCallTask = ApiHelper.OmdbIdApiCall(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      OmdbIdRoot root = JsonConvert.DeserializeObject<OmdbIdRoot>(jsonResponse.ToString());
      return root;
    }

    public static OmdbSearchRoot GetMoviesSearch(string id, string query, int page = 1)
    {
      var apiCallTask = ApiHelper.OmdbSearchApiCall(id, query, page);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      OmdbSearchRoot root = JsonConvert.DeserializeObject<OmdbSearchRoot>(jsonResponse.ToString());
      return root;
    }
  }
}