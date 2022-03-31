using Lana_jewelry.Domain;
using Lana_jewelry.Facade;

namespace Lana_jewelry.Pages {
    public abstract class FilteredPage<TView, TEntity, TRepo> : CrudPage<TView, TEntity, TRepo>
        where TView : UniqueView
        where TEntity : UniqueEntity
        where TRepo : IBaseRepo<TEntity> {
        protected FilteredPage(TRepo r) : base(r) { }
    }
}




