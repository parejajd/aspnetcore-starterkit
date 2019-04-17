
using CreApps.StarterKit.Models;
using Microsoft.EntityFrameworkCore;

namespace CreApps.StarterKit.DataAccess
{
    /// <summary>
    /// Repository that implements the CRUD operations
    /// </summary>
    /// <typeparam name="T">Model class where the CRUD operations will be executed</typeparam>
    /// <typeparam name="Tid">Class Identificator type</typeparam>
    public class Repository<T, TId> : RepositoryWithTypedId<T, TId>, IRepository<T, TId>
      where T : class, IEntityWithTypedId<TId>
    {
        public Repository(DbContext context) : base(context)
        {

        }
    }
}
