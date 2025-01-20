using B_RepositoryLayer.Data;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B_RepositoryLayer.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly ApplicationDbContext _context;


    public UserRepository(ApplicationDbContext context) : base(context) =>
        this._context = context;

    public async Task<User?> FindUserByEmailAsync(string email) =>
        await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

}

