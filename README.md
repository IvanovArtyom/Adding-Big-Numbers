## Description:
We need to sum big numbers and we require your help.

Write a function that returns the sum of two numbers. The input numbers are strings and the function must return a string.

### Example
```C#
add("123", "321"); -> "444"
add("11", "99");   -> "110"
```
### Notes
- The input numbers are **big**.
- The input is a string of only **digits**.
- The numbers are **positives**.
### My solution
```C#
using System.Numerics;

public class Kata
{
    public static string Add(string a, string b)
    {
        BigInteger A = BigInteger.Parse(a);
        BigInteger B = BigInteger.Parse(b);

        return (A + B).ToString();
    }
}
```
