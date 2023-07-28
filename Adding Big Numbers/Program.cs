using System.Numerics;

public class Kata
{
    public static void Main()
    {
        // Test
        var t = Add("123", "321");
        // ...should return "444"
    }

    public static string Add(string a, string b)
    {
        BigInteger A = BigInteger.Parse(a);
        BigInteger B = BigInteger.Parse(b);

        return (A + B).ToString();
    }
}