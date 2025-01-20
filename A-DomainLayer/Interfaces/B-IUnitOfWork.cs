namespace ClassLibrary1.Interfaces;

public interface IUnitOfWork : IAsyncDisposable
{
    IUserRepository UserRepository { get; set; }
        
    Task<int> Save();

}