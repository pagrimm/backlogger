namespace Backlogger.Models
{
  public class ShowUser
  {
    public int ShowUserId { get; set; }
    public int ShowId { get; set; }
    public string UserId { get; set; }
    public Show Show { get; set; }
    public ApplicationUser User { get; set; }
  }
}