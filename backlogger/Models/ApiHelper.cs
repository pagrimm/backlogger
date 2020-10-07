using System.Threading.Tasks;
using RestSharp;

namespace Backlogger.Models
{
  public class ApiHelper
  {
    public static async Task<string> OmdbIdApiCall(string id)
    {
      RestClient client = new RestClient("http://www.omdbapi.com/");
      RestRequest request = new RestRequest($"?apikey={EnvironmentVariables.OmdbKey}&i={id}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> OmdbSearchApiCall(string query, string type, int page = 1)
    {
      RestClient client = new RestClient("http://www.omdbapi.com/");
      RestRequest request = new RestRequest($"?apikey={EnvironmentVariables.OmdbKey}&s={query}&type={type}&page={page}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> RawgIdApiCall(long id)
    {
      RestClient client = new RestClient("https://api.rawg.io/api/games/");
      RestRequest request = new RestRequest($"{id}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> RawgSearchApiCall(string query, int page = 1, int pageSize = 20)
    {
      RestClient client = new RestClient("https://api.rawg.io/api/games");
      RestRequest request = new RestRequest($"?page={page}&page_size={pageSize}&search={query}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> TmdbMovieIdApiCall(int id)
    {
      RestClient client = new RestClient("https://api.themoviedb.org/3/movie/");
      RestRequest request = new RestRequest($"{id}?api_key={EnvironmentVariables.TmdbKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> TmdbMovieSearchApiCall(string query, int page = 1)
    {
      RestClient client = new RestClient("https://api.themoviedb.org/3/search/movie");
      RestRequest request = new RestRequest($"?api_key={EnvironmentVariables.TmdbKey}&query={query}&page={page}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> TmdbTvIdApiCall(int id)
    {
      RestClient client = new RestClient("https://api.themoviedb.org/3/tv/");
      RestRequest request = new RestRequest($"{id}?api_key={EnvironmentVariables.TmdbKey}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> TmdbTvSearchApiCall(string query, int page = 1)
    {
      RestClient client = new RestClient("https://api.themoviedb.org/3/search/tv");
      RestRequest request = new RestRequest($"?api_key={EnvironmentVariables.TmdbKey}&query={query}&page={page}");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}