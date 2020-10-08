using System.Collections.Generic;
using Backlogger.Models;
using Backlogger.ApiModels;

namespace Backlogger.ViewModels
{
  public class ItemListViewModel
  {
    public Item CurrentItem { get; set; }
    public long PreviousId { get; set; } = -1;
    public long NextId { get; set; } = -1;
  }
}