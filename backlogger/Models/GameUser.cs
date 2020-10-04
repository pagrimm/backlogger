namespace Backlogger.Models
{
  public class GameUser
  {
    public int GameUserId { get; set; }
    public int GameId { get; set; }
    public string UserId { get; set; }
    public Game Game { get; set; }
    public ApplicationUser User { get; set; }
  }
}