using System.Reflection;

namespace Lana_jewelry.Aids {
    public static class Methods {
        public static bool HasAttributes<TAttribute>(this MemberInfo? m) where TAttribute : Attribute
            => m?.GetAttributes<TAttribute>()is not null;
        public static TAttribute? GetAttributes<TAttribute>(this MemberInfo? m) where TAttribute : Attribute
    => Safe.Run(() => m?.GetCustomAttributes<TAttribute>()?.FirstOrDefault());
    }
      
}
