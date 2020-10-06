using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Backlogger.Models;

namespace Backlogger.ApiModels
{
  public partial class RawgIdRoot
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("name_original")]
    public string NameOriginal { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("metacritic")]
    public long Metacritic { get; set; }

    [JsonProperty("metacritic_platforms")]
    public List<RawgIdMetacriticPlatform> MetacriticPlatforms { get; set; }

    [JsonProperty("released")]
    public DateTimeOffset Released { get; set; }

    [JsonProperty("tba")]
    public bool Tba { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }

    [JsonProperty("background_image")]
    public string BackgroundImage { get; set; }

    [JsonProperty("background_image_additional")]
    public string BackgroundImageAdditional { get; set; }

    [JsonProperty("website")]
    public string Website { get; set; }

    [JsonProperty("rating")]
    public double Rating { get; set; }

    [JsonProperty("rating_top")]
    public long RatingTop { get; set; }

    [JsonProperty("ratings")]
    public List<RawgIdRating> Ratings { get; set; }

    [JsonProperty("reactions")]
    public Dictionary<string, long> Reactions { get; set; }

    [JsonProperty("added")]
    public long Added { get; set; }

    [JsonProperty("added_by_status")]
    public RawgIdAddedByStatus AddedByStatus { get; set; }

    [JsonProperty("playtime")]
    public long Playtime { get; set; }

    [JsonProperty("screenshots_count")]
    public long ScreenshotsCount { get; set; }

    [JsonProperty("movies_count")]
    public long MoviesCount { get; set; }

    [JsonProperty("creators_count")]
    public long CreatorsCount { get; set; }

    [JsonProperty("achievements_count")]
    public long AchievementsCount { get; set; }

    [JsonProperty("parent_achievements_count")]
    public long ParentAchievementsCount { get; set; }

    [JsonProperty("reddit_url")]
    public string RedditUrl { get; set; }

    [JsonProperty("reddit_name")]
    public string RedditName { get; set; }

    [JsonProperty("reddit_description")]
    public string RedditDescription { get; set; }

    [JsonProperty("reddit_logo")]
    public string RedditLogo { get; set; }

    [JsonProperty("reddit_count")]
    public long RedditCount { get; set; }

    [JsonProperty("twitch_count")]
    public long TwitchCount { get; set; }

    [JsonProperty("youtube_count")]
    public long YoutubeCount { get; set; }

    [JsonProperty("reviews_text_count")]
    public long ReviewsTextCount { get; set; }

    [JsonProperty("ratings_count")]
    public long RatingsCount { get; set; }

    [JsonProperty("suggestions_count")]
    public long SuggestionsCount { get; set; }

    [JsonProperty("alternative_names")]
    public List<object> AlternativeNames { get; set; }

    [JsonProperty("metacritic_url")]
    public string MetacriticUrl { get; set; }

    [JsonProperty("parents_count")]
    public long ParentsCount { get; set; }

    [JsonProperty("additions_count")]
    public long AdditionsCount { get; set; }

    [JsonProperty("game_series_count")]
    public long GameSeriesCount { get; set; }

    [JsonProperty("user_game")]
    public object UserGame { get; set; }

    [JsonProperty("reviews_count")]
    public long ReviewsCount { get; set; }

    [JsonProperty("saturated_color")]
    public string SaturatedColor { get; set; }

    [JsonProperty("dominant_color")]
    public string DominantColor { get; set; }

    [JsonProperty("parent_platforms")]
    public List<RawgIdParentPlatform> ParentPlatforms { get; set; }

    [JsonProperty("platforms")]
    public List<RawgIdPlatformElement> Platforms { get; set; }

    [JsonProperty("stores")]
    public List<RawgIdStore> Stores { get; set; }

    [JsonProperty("developers")]
    public List<RawgIdDeveloper> Developers { get; set; }

    [JsonProperty("genres")]
    public List<RawgIdDeveloper> Genres { get; set; }

    [JsonProperty("tags")]
    public List<RawgIdDeveloper> Tags { get; set; }

    [JsonProperty("publishers")]
    public List<RawgIdDeveloper> Publishers { get; set; }

    [JsonProperty("esrb_rating")]
    public RawgIdEsrbRating EsrbRating { get; set; }

    [JsonProperty("clip")]
    public RawgIdClip Clip { get; set; }

    [JsonProperty("description_raw")]
    public string DescriptionRaw { get; set; }

    public static RawgIdRoot GetMovieById(int id)
    {
      var apiCallTask = ApiHelper.RawgIdApiCall(id);
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      RawgIdRoot root = JsonConvert.DeserializeObject<RawgIdRoot>(jsonResponse.ToString());
      return root;
    }
  }

  public partial class RawgIdAddedByStatus
  {
    [JsonProperty("yet")]
    public long Yet { get; set; }

    [JsonProperty("owned")]
    public long Owned { get; set; }

    [JsonProperty("beaten")]
    public long Beaten { get; set; }

    [JsonProperty("toplay")]
    public long Toplay { get; set; }

    [JsonProperty("dropped")]
    public long Dropped { get; set; }

    [JsonProperty("playing")]
    public long Playing { get; set; }
  }

  public partial class RawgIdClip
  {
    [JsonProperty("clip")]
    public string ClipClip { get; set; }

    [JsonProperty("clips")]
    public RawgIdClips Clips { get; set; }

    [JsonProperty("video")]
    public string Video { get; set; }

    [JsonProperty("preview")]
    public string Preview { get; set; }
  }

  public partial class RawgIdClips
  {
    [JsonProperty("320")]
    public string The320 { get; set; }

    [JsonProperty("640")]
    public string The640 { get; set; }

    [JsonProperty("full")]
    public string Full { get; set; }
  }

  public partial class RawgIdDeveloper
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonProperty("games_count")]
    public long GamesCount { get; set; }

    [JsonProperty("image_background")]
    public string ImageBackground { get; set; }

    [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
    public string Domain { get; set; }
  }

  public partial class RawgIdEsrbRating
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }
  }

  public partial class RawgIdMetacriticPlatform
  {
    [JsonProperty("metascore")]
    public long Metascore { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("platform")]
    public RawgIdMetacriticPlatformPlatform Platform { get; set; }
  }

  public partial class RawgIdMetacriticPlatformPlatform
  {
    [JsonProperty("platform")]
    public long Platform { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }
  }

  public partial class RawgIdParentPlatform
  {
    [JsonProperty("platform")]
    public RawgIdEsrbRating Platform { get; set; }
  }

  public partial class RawgIdPlatformElement
  {
    [JsonProperty("platform")]
    public RawgIdPlatformPlatform Platform { get; set; }

    [JsonProperty("released_at")]
    public DateTimeOffset ReleasedAt { get; set; }

    [JsonProperty("requirements")]
    public RawgIdRequirements Requirements { get; set; }
  }

  public partial class RawgIdPlatformPlatform
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonProperty("image")]
    public object Image { get; set; }

    [JsonProperty("year_end")]
    public object YearEnd { get; set; }

    [JsonProperty("year_start")]
    public object YearStart { get; set; }

    [JsonProperty("games_count")]
    public long GamesCount { get; set; }

    [JsonProperty("image_background")]
    public string ImageBackground { get; set; }
  }

  public partial class RawgIdRequirements
  {
    [JsonProperty("minimum")]
    public string Minimum { get; set; }

    [JsonProperty("recommended")]
    public string Recommended { get; set; }
  }

  public partial class RawgIdRating
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("count")]
    public long Count { get; set; }

    [JsonProperty("percent")]
    public double Percent { get; set; }
  }

  public partial class RawgIdStore
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("store")]
    public RawgIdDeveloper StoreStore { get; set; }
  }
}