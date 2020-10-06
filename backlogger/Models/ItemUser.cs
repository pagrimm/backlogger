namespace Backlogger.Models
{
  public class ItemUser
  {
    public int ItemUserId { get; set; }
    public int ItemId { get; set; }
    public string UserId { get; set; }
    public Item Item { get; set; }
    public ApplicationUser User { get; set; }
  }
}