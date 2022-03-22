namespace Lana_jewelry.Aids {
    public static class Chars {
        public static bool IsNameChar(this char x) => char.IsLetterOrDigit(x);
        public static bool IsFullNameChar(this char x) => char.IsLetterOrDigit(x) || x == '.' || x == '`';
    }

}
