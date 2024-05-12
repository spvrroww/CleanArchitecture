using SchoolManagementApp.Domain.Primitives;

namespace SchoolManagementApp.Domain.Exceptions.Base;

public class BaseNotFoundException<TEntity> : Exception where TEntity : Entity
{
    public BaseNotFoundException(Guid id) : base($"{typeof(TEntity).Name} with id: {id} Not found")
    {
        
    }
}
