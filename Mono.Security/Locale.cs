public static class Locale
{
    public static string GetText(string s, params object[] p) => string.Format(s, p);
}
