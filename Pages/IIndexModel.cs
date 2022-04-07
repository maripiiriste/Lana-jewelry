
using Lana_jewelry.Facade;

namespace Lana_jewelry.Pages {
    public interface IIndexModel<TView> where TView:UniqueView {
        public string[] IndexColumns { get; }
        public IList<TView>? Items{ get; }
        public object? GetValue(string name, TView v);
        string DisplayName(string name);
    }
}
