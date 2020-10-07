using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Backlogger.Models;

namespace Backlogger.ApiModels
{
  public class Rawg
  {
    public static RawgIdRoot GetGameById(int id)
    {
      var apiCallTask = ApiHelper.RawgIdApiCall(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      RawgIdRoot root = JsonConvert.DeserializeObject<RawgIdRoot>(jsonResponse.ToString());
      return root;
    }

    public static RawgSearchRoot GetGamesSearch(string query, int page = 1, int pageSize = 20)
    {
      var apiCallTask = ApiHelper.RawgSearchApiCall(query, page, pageSize);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      RawgSearchRoot root = JsonConvert.DeserializeObject<RawgSearchRoot>(jsonResponse.ToString());
      return root;
    }
  }
}