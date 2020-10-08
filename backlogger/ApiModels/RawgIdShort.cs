using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Backlogger.Models;

namespace Backlogger.ApiModels
{
  public partial class RawgIdRootShort
  {
    [JsonProperty("description_raw")]
    public string DescriptionRaw { get; set; }
  }
}