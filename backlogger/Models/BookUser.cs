namespace Backlogger.Models
{
  public class BookUser
  {
    public int BookUserId { get; set; }
    public int BookId { get; set; }
    public string UserId { get; set; }
    public Book Book { get; set; }
    public ApplicationUser User { get; set; }
  }
}