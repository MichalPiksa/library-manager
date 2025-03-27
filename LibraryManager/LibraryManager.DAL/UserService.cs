using Marten;

namespace LibraryManager.DAL;

public class UserService : IUserService
{
    private readonly IDocumentStore _store;

    public UserService(IDocumentStore store)
    {
        _store = store;
    }

    public async Task<IEnumerable<User>> GetUsers()
    {
        using var session = _store.QuerySession();
        return await session.Query<User>().ToListAsync();
    }

    public async Task<User?> GetUser(Guid id)
    {
        using var session = _store.QuerySession();
        return await session.LoadAsync<User>(id);
    }

    public async Task CreateUser(User user)
    {
        using var session = _store.LightweightSession();
        session.Store(user);
        await session.SaveChangesAsync();
    }

    public async Task UpdateUser(User user)
    {
        using var session = _store.LightweightSession();
        session.Update(user);
        await session.SaveChangesAsync();
    }

    public async Task DeleteUser(User user)
    {
        using var session = _store.LightweightSession();
        session.Delete(user);
        await session.SaveChangesAsync();
    }
}