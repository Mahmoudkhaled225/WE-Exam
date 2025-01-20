using B_RepositoryLayer.Data;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B_RepositoryLayer.Repositories;

public class GenericRepository <T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly ApplicationDbContext Context;

    protected GenericRepository(ApplicationDbContext context) =>
        Context = context;
    
    public async Task<T?> Get(int? id) =>
        await Context.Set<T>().FindAsync(id);

    public async Task<IEnumerable<T>> GetAll() =>
        await Context.Set<T>().ToListAsync();
    
    public async Task Add(T entity) =>
        await Context.Set<T>().AddAsync(entity);

    public void Delete(T entity) =>
        Context.Set<T>().Remove(entity);

    public void Update(T entity) =>
        Context.Set<T>().Update(entity);


    public async Task<IEnumerable<T?>> GetAllFunc(Func<T, bool> match) =>
        throw new NotImplementedException();

}