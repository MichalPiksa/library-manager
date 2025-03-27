namespace LibraryManager.DAL;

public class User
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<Book> Books { get; set; }
}