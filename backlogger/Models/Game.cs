using System;
using System.Collections.Generic;

namespace Backlogger.Models
{
  public class Game
  {
    public Game()
    {
      this.Users = new HashSet<GameUser>();
    }
    public int GameId { get; set; }
    public ICollection<GameUser> Users { get; set; }
  }
}