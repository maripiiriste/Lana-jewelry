
using Lana_jewelry.Data;

namespace Lana_jewelry.Domain {
    public abstract class UniqueEntity {
        private const double defaultNr = 00.00;
        public static string DefaultStr => "Undefined";
        private static DateTime defaultDate => DateTime.MinValue;
        protected static string getValue(string? v) => v ?? DefaultStr;
        protected static DateTime getValue(DateTime? v) => v ?? defaultDate;
        protected static double getValue(double? v) => v ?? defaultNr;
        public abstract string Id{get;}
        public abstract byte[] Token { get; }
    }
    public abstract class UniqueEntity<TData> : UniqueEntity where TData : UniqueData, new() {
        private readonly TData data;
        public TData Data => data;
        public UniqueEntity() : this(new TData()) { }
        public UniqueEntity(TData d) => data = d;
        public override string Id => getValue(Data?.Id); 
        public override byte[] Token => Data?.Token?? Array.Empty<byte>();
    }
}
