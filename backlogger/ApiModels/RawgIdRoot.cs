using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Backlogger.Models
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
    public MetacriticPlatform[] MetacriticPlatforms { get; set; }

    [JsonProperty("released")]
    public DateTimeOffset Released { get; set; }

    [JsonProperty("tba")]
    public bool Tba { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }

    [JsonProperty("background_image")]
    public Uri BackgroundImage { get; set; }

    [JsonProperty("background_image_additional")]
    public Uri BackgroundImageAdditional { get; set; }

    [JsonProperty("website")]
    public Uri Website { get; set; }

    [JsonProperty("rating")]
    public double Rating { get; set; }

    [JsonProperty("rating_top")]
    public long RatingTop { get; set; }

    [JsonProperty("ratings")]
    public Rating[] Ratings { get; set; }

    [JsonProperty("reactions")]
    public Dictionary<string, long> Reactions { get; set; }

    [JsonProperty("added")]
    public long Added { get; set; }

    [JsonProperty("added_by_status")]
    public AddedByStatus AddedByStatus { get; set; }

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
    public Uri RedditUrl { get; set; }

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
    public object[] AlternativeNames { get; set; }

    [JsonProperty("metacritic_url")]
    public Uri MetacriticUrl { get; set; }

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
    public ParentPlatform[] ParentPlatforms { get; set; }

    [JsonProperty("platforms")]
    public PlatformElement[] Platforms { get; set; }

    [JsonProperty("stores")]
    public Store[] Stores { get; set; }

    [JsonProperty("developers")]
    public Developer[] Developers { get; set; }

    [JsonProperty("genres")]
    public Developer[] Genres { get; set; }

    [JsonProperty("tags")]
    public Developer[] Tags { get; set; }

    [JsonProperty("publishers")]
    public Developer[] Publishers { get; set; }

    [JsonProperty("esrb_rating")]
    public EsrbRating EsrbRating { get; set; }

    [JsonProperty("clip")]
    public Clip Clip { get; set; }

    [JsonProperty("description_raw")]
    public string DescriptionRaw { get; set; }
  }

  public partial class AddedByStatus
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

  public partial class Clip
  {
    [JsonProperty("clip")]
    public Uri ClipClip { get; set; }

    [JsonProperty("clips")]
    public Clips Clips { get; set; }

    [JsonProperty("video")]
    public string Video { get; set; }

    [JsonProperty("preview")]
    public Uri Preview { get; set; }
  }

  public partial class Clips
  {
    [JsonProperty("320")]
    public Uri The320 { get; set; }

    [JsonProperty("640")]
    public Uri The640 { get; set; }

    [JsonProperty("full")]
    public Uri Full { get; set; }
  }

  public partial class Developer
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
    public Uri ImageBackground { get; set; }

    [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
    public string Domain { get; set; }

    [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
    public Language? Language { get; set; }
  }

  public partial class EsrbRating
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }
  }

  public partial class MetacriticPlatform
  {
    [JsonProperty("metascore")]
    public long Metascore { get; set; }

    [JsonProperty("url")]
    public Uri Url { get; set; }

    [JsonProperty("platform")]
    public MetacriticPlatformPlatform Platform { get; set; }
  }

  public partial class MetacriticPlatformPlatform
  {
    [JsonProperty("platform")]
    public long Platform { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }
  }

  public partial class ParentPlatform
  {
    [JsonProperty("platform")]
    public EsrbRating Platform { get; set; }
  }

  public partial class PlatformElement
  {
    [JsonProperty("platform")]
    public PlatformPlatform Platform { get; set; }

    [JsonProperty("released_at")]
    public DateTimeOffset ReleasedAt { get; set; }

    [JsonProperty("requirements")]
    public Requirements Requirements { get; set; }
  }

  public partial class PlatformPlatform
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
    public Uri ImageBackground { get; set; }
  }

  public partial class Requirements
  {
    [JsonProperty("minimum")]
    public string Minimum { get; set; }

    [JsonProperty("recommended")]
    public string Recommended { get; set; }
  }

  public partial class Rating
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

  public partial class Store
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("url")]
    public Uri Url { get; set; }

    [JsonProperty("store")]
    public Developer StoreStore { get; set; }
  }
}