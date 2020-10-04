namespace Backlogger.Models
{
  public class MovieUser
  {
    public int MovieUserId { get; set; }
    public int MovieId { get; set; }
    public string UserId { get; set; }
    public Movie Movie { get; set; }
    public ApplicationUser User { get; set; }
  }
}