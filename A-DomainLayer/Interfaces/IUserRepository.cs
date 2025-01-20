using ClassLibrary1.Entities;

namespace ClassLibrary1.Interfaces;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User?> FindUserByEmailAsync(string email);


}