using Lana_jewelry.Domain;
using Lana_jewelry.Facade;

namespace Lana_jewelry.Pages {
    public abstract class FilteredPage<TView, TEntity, TRepo> : CrudPage<TView, TEntity, TRepo>
        where TView : UniqueView
        where TEntity : UniqueEntity
        where TRepo : IFilteredRepo<TEntity> {
        protected FilteredPage(TRepo r) : base(r) { }
        public string? CurrentFilter {
            get => repo.CurrentFilter;
            set => repo.CurrentFilter = value;
        }
    }
}




