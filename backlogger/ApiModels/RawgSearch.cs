using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Backlogger.ApiModels
{
  public partial class RawgSearchRoot
  {
    [JsonProperty("count")]
    public long Count { get; set; }

    [JsonProperty("next")]
    public string Next { get; set; }

    [JsonProperty("previous")]
    public object Previous { get; set; }

    [JsonProperty("results")]
    public List<RawgSearchResult> Results { get; set; }

    [JsonProperty("user_platforms")]
    public bool UserPlatforms { get; set; }
  }

  public partial class RawgSearchResult
  {
    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("playtime")]
    public long Playtime { get; set; }

    [JsonProperty("platforms")]
    public List<RawgSearchPlatform> Platforms { get; set; }

    [JsonProperty("stores")]
    public List<RawgSearchStore> Stores { get; set; }

    [JsonProperty("released")]
    public DateTimeOffset Released { get; set; }

    [JsonProperty("tba")]
    public bool Tba { get; set; }

    [JsonProperty("background_image")]
    public string BackgroundImage { get; set; }

    [JsonProperty("rating")]
    public double Rating { get; set; }

    [JsonProperty("rating_top")]
    public long RatingTop { get; set; }

    [JsonProperty("ratings")]
    public List<RawgSearchRating> Ratings { get; set; }

    [JsonProperty("ratings_count")]
    public long RatingsCount { get; set; }

    [JsonProperty("reviews_text_count")]
    public long ReviewsTextCount { get; set; }

    [JsonProperty("added")]
    public long Added { get; set; }

    [JsonProperty("added_by_status")]
    public RawgSearchAddedByStatus AddedByStatus { get; set; }

    [JsonProperty("metacritic")]
    public long? Metacritic { get; set; }

    [JsonProperty("suggestions_count")]
    public long SuggestionsCount { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("score")]
    public string Score { get; set; }

    [JsonProperty("clip")]
    public RawgSearchClip Clip { get; set; }

    [JsonProperty("tags")]
    public List<RawgSearchTag> Tags { get; set; }

    [JsonProperty("user_game")]
    public object UserGame { get; set; }

    [JsonProperty("reviews_count")]
    public long ReviewsCount { get; set; }

    [JsonProperty("community_rating", NullValueHandling = NullValueHandling.Ignore)]
    public long? CommunityRating { get; set; }

    [JsonProperty("saturated_color")]
    public string SaturatedColor { get; set; }

    [JsonProperty("dominant_color")]
    public string DominantColor { get; set; }

    [JsonProperty("short_screenshots")]
    public List<RawgSearchShortScreenshot> ShortScreenshots { get; set; }

    [JsonProperty("parent_platforms")]
    public List<RawgSearchPlatform> ParentPlatforms { get; set; }

    [JsonProperty("genres")]
    public List<RawgSearchGenre> Genres { get; set; }
  }

  public partial class RawgSearchAddedByStatus
  {
    [JsonProperty("yet", NullValueHandling = NullValueHandling.Ignore)]
    public long? Yet { get; set; }

    [JsonProperty("owned")]
    public long Owned { get; set; }

    [JsonProperty("beaten", NullValueHandling = NullValueHandling.Ignore)]
    public long? Beaten { get; set; }

    [JsonProperty("toplay", NullValueHandling = NullValueHandling.Ignore)]
    public long? Toplay { get; set; }

    [JsonProperty("dropped", NullValueHandling = NullValueHandling.Ignore)]
    public long? Dropped { get; set; }

    [JsonProperty("playing", NullValueHandling = NullValueHandling.Ignore)]
    public long? Playing { get; set; }
  }

  public partial class RawgSearchClip
  {
    [JsonProperty("clip")]
    public string ClipClip { get; set; }

    [JsonProperty("clips")]
    public RawgSearchClips Clips { get; set; }

    [JsonProperty("video")]
    public string Video { get; set; }

    [JsonProperty("preview")]
    public string Preview { get; set; }
  }

  public partial class RawgSearchClips
  {
    [JsonProperty("320")]
    public string The320 { get; set; }

    [JsonProperty("640")]
    public string The640 { get; set; }

    [JsonProperty("full")]
    public string Full { get; set; }
  }

  public partial class RawgSearchGenre
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }
  }

  public partial class RawgSearchPlatform
  {
    [JsonProperty("platform")]
    public string PlatformPlatform { get; set; }
  }

  public partial class RawgSearchRating
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

  public partial class RawgSearchShortScreenshot
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("image")]
    public string Image { get; set; }
  }

  public partial class RawgSearchStore
  {
    [JsonProperty("store")]
    public RawgSearchStoreStore StoreStore { get; set; }
  }

  public partial class RawgSearchStoreStore
  {
    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("slug")]
    public string Slug { get; set; }
  }

  public partial class RawgSearchTag
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("games_count")]
    public long GamesCount { get; set; }

    [JsonProperty("image_background")]
    public string ImageBackground { get; set; }
  }
}