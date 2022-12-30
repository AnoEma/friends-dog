namespace Infra.BaseRepository;

public interface IRepositoryBase<T> where T : class
{
    Task<IList<T>> GetAllAsync();
    Task CreateAsync(T model);

}