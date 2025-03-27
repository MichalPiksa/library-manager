namespace LibraryManager.DAL;

public interface IUserService
{
    Task<IEnumerable<User>> GetUsers();
    Task<User?> GetUser(Guid id);
    Task CreateUser(User user);
    Task UpdateUser(User user);
    Task DeleteUser(User user);
}