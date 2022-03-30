﻿using Lana_jewelry.Data;
using Lana_jewelry.Domain;
using System.Reflection;

namespace Lana_jewelry.Facade{
    public abstract class BaseViewFactory<TView, TEntity, TData>
        where TView : class, new()
        where TData : UniqueData, new()
        where TEntity : UniqueEntity<TData> {
        protected abstract TEntity toEntity(TData d);
        protected virtual void copy(object? from, object? to) {
            var tFrom = from?.GetType();
            var tTo = to?.GetType();
            foreach (var propertyInfoFrom in tFrom?.GetProperties() ?? Array.Empty<PropertyInfo>()) {
                var v = propertyInfoFrom.GetValue(from, null);
                var propertyInfoTo = tTo?.GetProperty(propertyInfoFrom.Name);
                propertyInfoTo?.SetValue(to, v, null);
            }
        }

        public virtual TEntity Create(TView? v) {
            var d = new TData();
            copy(v, d);
            return toEntity(d);
        }

        public virtual TView Create(TEntity? e) {
            var d = e?.Data;
            var v = new TView();
            copy(d, v);
            return v;
        }
    }

}
    
    
            


