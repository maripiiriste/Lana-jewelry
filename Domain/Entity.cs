
using Lana_jewelry.Data;

namespace Lana_jewelry.Domain{
    public abstract class Entity{
        private const double defaultNr = 00.00;
        public static string DefaultStr => "Undefined";
        private static DateTime defaultDate => DateTime.MinValue;
        protected static string getValue(string? v) => v ?? DefaultStr;
        protected static DateTime getValue(DateTime? v) => v ?? defaultDate;
        protected static double getValue(double? v) => v ?? defaultNr;
    }
    public abstract class Entity<TData> : Entity where TData : EntityData, new() {
        private readonly TData data;
        public TData Data => data;
        public Entity() : this(new TData()) { }
        public Entity(TData d) => data = d;
        public string Id => getValue(Data?.Id);
    }
}
