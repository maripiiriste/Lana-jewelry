using Lana_jewelry.Data;

namespace Lana_jewelry.Domain {
    public abstract class UniqueEntity {
        private const double DefaultNr = 00.00;
        public static int DefaultInt=0;
        public static string DefaultStr => "Undefined";
        private static DateTime DefaultDate => DateTime.MinValue;
        protected static string getValue(string? v) => v ?? DefaultStr;
        protected static DateTime getValue(DateTime? v) => v ?? DefaultDate;
        protected static double getValue(double? v) => v ?? DefaultNr;
        protected static int getValue(int? v) => v ?? DefaultInt;
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
