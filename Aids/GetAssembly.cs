using System.Reflection;

namespace Lana_jewelry.Aids {
    static class GetAssembly {
        public static Assembly? Byname(string? name) => Safe.Run(() => Assembly.Load(name ?? String.Empty));
        public static Assembly? OfType(object obj) => Safe.Run(() => obj.GetType().Assembly);
        public static List<Type>? Types(Assembly? a) => Safe.Run(() => a?.GetTypes()?.ToList(), new());
        public static Type? Type(this Assembly? a, string? name)
            => Safe.Run(() => a?.DefinedTypes?.FirstOrDefault(X => X.Name == name));
    }
      
}
