namespace Lana_jewelry.Data.Party {
    public sealed class ShoppingBagData:UniqueData {
        public double Total { get; set; }
        public string? Delivery { get; set; } //next-day delivery, express delivery
        public string? PaymentSystem { get; set; }
        public string? DiscountCode { get; set; }

    }
}
