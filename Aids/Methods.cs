using System.Reflection;

namespace Lana_jewelry.Aids {
    public static class Methods {
        public static bool HasAttributes<TAttribute>(this MethodInfo? m) where TAttribute : Attribute
            => Safe.Run(() => m?.GetCustomAttributes<TAttribute>()?.FirstOrDefault() is not null, false);
    }
      
}
