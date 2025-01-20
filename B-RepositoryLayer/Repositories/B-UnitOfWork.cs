using B_RepositoryLayer.Data;
using ClassLibrary1.Interfaces;

namespace B_RepositoryLayer.Repositories;

public class UnitOfWork : IUnitOfWork   
{
    private readonly ApplicationDbContext _context; 
    public IUserRepository UserRepository { get; set; }

    
    public UnitOfWork(ApplicationDbContext context, IUserRepository userRepository)
    {
        _context = context;
        UserRepository = userRepository;
    }
    
    

    public async Task<int> Save() => 
        await _context.SaveChangesAsync();
    
    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
        // for better performance, 
        // use it when your class might be inherited by other classes that could introduce a finalizer
        // This will prevent the garbage collector from calling the finalizer of the UnitOfWork object, if one exists
        GC.SuppressFinalize(this);

    }

}