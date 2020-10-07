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
    public long RawgId { get; set; }
    public long TmdbId { get; set; }
    public int Priority { get; set; }
    public DateTime AddedDate { get; set; }
    public ICollection<ItemUser> Users { get; set; }

    public void GetRawgValues(RawgIdRoot input)
    {
      this.Type = "Game";
      this.RawgId = input.Id;
    }

    public void GetTmdbMovieValues(TmdbMovieRoot input)
    {
      this.Type = "Movie";
      this.TmdbId = input.Id;
    }

    public void GetTmdbTvValues(TmdbTvRoot input)
    {
      this.Type = "TV";
      this.TmdbId = input.Id;
    }
  }
}