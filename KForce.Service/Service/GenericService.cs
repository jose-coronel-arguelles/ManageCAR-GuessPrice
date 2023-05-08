using KForce.Service.Repositories;

namespace KForce.Service.Service;

public class GenericService<T> : IGenericService<T> where T : class
{

    private readonly IGenericRepository<T> _repository;

    public GenericService(IGenericRepository<T> repository) => this._repository = repository;

    public int Delete(T entity) => _repository.Delete(entity);

    public T GetById(int id) => _repository.GetById(id);

    public IEnumerable<T> GetAll() => _repository.GetAll();

    public int Add(T entity) => _repository.Add(entity);

    public int Update(T entity) => _repository.Update(entity);

}
