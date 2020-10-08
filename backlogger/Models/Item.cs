using System;
using System.Collections.Generic;
using Backlogger.ApiModels;
using System.Linq;

namespace Backlogger.Models
{
  public class Item
  {
    public Item()
    {
      this.Users = new HashSet<ItemUser>();
    }
    public int ItemId { get; set; }
    public string Type { get; set; }
    public long ApiId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Released { get; set; }
    public string BackgroundImage { get; set; }
    public string Poster { get; set; }
    public int Priority { get; set; }
    public DateTime AddedDate { get; set; } = DateTime.Now;
    public bool Watched { get; set; } = false;
    public ICollection<ItemUser> Users { get; set; }

    public void GetRawgValues(RawgIdRoot input)
    {
      this.Type = "game";
      this.ApiId = input.Id;
      this.Name = input.Name;
      if (input.DescriptionRaw.Length > 500)
      {
        this.Description = input.DescriptionRaw.Substring(0, 500) + "...(CONT.)";
      }
      else
      {
        this.Description = input.DescriptionRaw;
      }
      this.Released = input.Released;
      this.BackgroundImage = input.BackgroundImage;
    }

    public void GetTmdbMovieValues(TmdbMovieRoot input)
    {
      this.Type = "movie";
      this.Name = input.Title;
      this.ApiId = input.Id;
      this.Description = input.Overview;
      this.Released = input.ReleaseDate;
      if (!String.IsNullOrEmpty(input.BackdropPath))
      {
        this.BackgroundImage = "https://image.tmdb.org/t/p/original" + input.BackdropPath;
      }
      if (!String.IsNullOrEmpty(input.PosterPath))
      {
        this.Poster = "https://image.tmdb.org/t/p/original" + input.PosterPath;
      }
    }

    public void GetTmdbTvValues(TmdbTvRoot input)
    {
      this.Type = "tv";
      this.Name = input.Name;
      this.ApiId = input.Id;
      if (!String.IsNullOrEmpty(input.Overview))
      {
        this.Description = input.Overview;
      }
      if (!String.IsNullOrEmpty(input.FirstAirDate))
      {
        this.Released = input.FirstAirDate;
      }
      if (!String.IsNullOrEmpty(input.BackdropPath))
      {
        this.BackgroundImage = "https://image.tmdb.org/t/p/original" + input.BackdropPath;
      }
      if (!String.IsNullOrEmpty(input.PosterPath))
      {
        this.Poster = "https://image.tmdb.org/t/p/original" + input.PosterPath;
      }
    }
  }
}