namespace Infra.BaseRepository;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class { 

    public async Task<IList<T>> GetAllAsync()
    {
        return new List<T>();
    }
    virtual public async Task CreateAsync(T model)
    {

    }
}