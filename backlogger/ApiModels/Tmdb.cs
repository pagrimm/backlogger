using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Backlogger.Models;

namespace Backlogger.ApiModels
{
  public class Tmdb
  {
    public static TmdbMovieRoot GetMovieById(int id)
    {
      var apiCallTask = ApiHelper.TmdbMovieIdApiCall(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      TmdbMovieRoot root = JsonConvert.DeserializeObject<TmdbMovieRoot>(jsonResponse.ToString());
      return root;
    }

    public static TmdbMovieSearchRoot GetMoviesSearch(string query, int page = 1)
    {
      var apiCallTask = ApiHelper.TmdbMovieSearchApiCall(query, page);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      TmdbMovieSearchRoot root = JsonConvert.DeserializeObject<TmdbMovieSearchRoot>(jsonResponse.ToString());
      return root;
    }

    public static TmdbTvRoot GetTvById(int id)
    {
      var apiCallTask = ApiHelper.TmdbTvIdApiCall(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      TmdbTvRoot root = JsonConvert.DeserializeObject<TmdbTvRoot>(jsonResponse.ToString());
      return root;
    }

    public static TmdbTvSearchRoot GetTvSearch(string query, int page = 1)
    {
      var apiCallTask = ApiHelper.TmdbTvSearchApiCall(query, page);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      TmdbTvSearchRoot root = JsonConvert.DeserializeObject<TmdbTvSearchRoot>(jsonResponse.ToString());
      return root;
    }
  }
}