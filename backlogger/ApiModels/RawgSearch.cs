namespace Backlogger.ApiModels
{
  using System;
  using System.Collections.Generic;

  using System.Globalization;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

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
    public string Released { get; set; }

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

    [JsonProperty("short_screenshots")]
    public List<RawgSearchShortScreenshot> ShortScreenshots { get; set; }

    [JsonProperty("parent_platforms")]
    public List<RawgSearchPlatform> ParentPlatforms { get; set; }

    [JsonProperty("genres")]
    public List<Genre> Genres { get; set; }

    [JsonProperty("community_rating", NullValueHandling = NullValueHandling.Ignore)]
    public long? CommunityRating { get; set; }
    public string DescriptionRaw { get; set; }
  }

  public partial class RawgSearchAddedByStatus
  {
    [JsonProperty("yet", NullValueHandling = NullValueHandling.Ignore)]
    public long? Yet { get; set; }

    [JsonProperty("owned", NullValueHandling = NullValueHandling.Ignore)]
    public long? Owned { get; set; }

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
    public RawgSearchGenre PlatformPlatform { get; set; }
  }

  public partial class RawgSearchRating
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("title")]
    public Title Title { get; set; }

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
    public RawgSearchGenre StoreStore { get; set; }
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
    public Language Language { get; set; }

    [JsonProperty("games_count")]
    public long GamesCount { get; set; }

    [JsonProperty("image_background")]
    public string ImageBackground { get; set; }
  }

  public enum Title { Exceptional, Meh, Recommended, Skip };

  public enum Language { Eng, Rus };

  internal static class Converter
  {
    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    {
      MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
      DateParseHandling = DateParseHandling.None,
      Converters =
      {
        TitleConverter.Singleton,
        LanguageConverter.Singleton,
        new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
      },
    };
  }

  internal class TitleConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(Title) || t == typeof(Title?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if (reader.TokenType == JsonToken.Null) return null;
      var value = serializer.Deserialize<string>(reader);
      switch (value)
      {
        case "exceptional":
          return Title.Exceptional;
        case "meh":
          return Title.Meh;
        case "recommended":
          return Title.Recommended;
        case "skip":
          return Title.Skip;
      }
      throw new Exception("Cannot unmarshal type Title");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if (untypedValue == null)
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (Title)untypedValue;
      switch (value)
      {
        case Title.Exceptional:
          serializer.Serialize(writer, "exceptional");
          return;
        case Title.Meh:
          serializer.Serialize(writer, "meh");
          return;
        case Title.Recommended:
          serializer.Serialize(writer, "recommended");
          return;
        case Title.Skip:
          serializer.Serialize(writer, "skip");
          return;
      }
      throw new Exception("Cannot marshal type Title");
    }

    public static readonly TitleConverter Singleton = new TitleConverter();
  }

  internal class LanguageConverter : JsonConverter
  {
    public override bool CanConvert(Type t) => t == typeof(Language) || t == typeof(Language?);

    public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
    {
      if (reader.TokenType == JsonToken.Null) return null;
      var value = serializer.Deserialize<string>(reader);
      switch (value)
      {
        case "eng":
          return Language.Eng;
        case "rus":
          return Language.Rus;
      }
      throw new Exception("Cannot unmarshal type Language");
    }

    public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
    {
      if (untypedValue == null)
      {
        serializer.Serialize(writer, null);
        return;
      }
      var value = (Language)untypedValue;
      switch (value)
      {
        case Language.Eng:
          serializer.Serialize(writer, "eng");
          return;
        case Language.Rus:
          serializer.Serialize(writer, "rus");
          return;
      }
      throw new Exception("Cannot marshal type Language");
    }

    public static readonly LanguageConverter Singleton = new LanguageConverter();
  }
}
