using System;
using System.Linq;


public class Program
{
    public static void Main()
    {

    }
    public int Sort(int[] arr)
    {
        if (arr.Length == 0)
        {
            return 0;
        }

        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr[3];
    }

    public int Palindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        string lowerCasePal = s.ToLower();
        if (lowerCasePal.SequenceEqual(lowerCasePal.Reverse()))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public int Factorial(int n)
    {
        if (n < 0)
        {
            return 0;
        }
        if (n == 0)
        {
            return 1;
        }
        else if (n > 13)
        {
            return -1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }

    public int Fibonnachi(int m)
    {
        if (m == 0)
        {
            return 0;
        }
        else if (m == 1 || m == -1)
        {
            return 1;
        }

        else if (m > 1)
        {
            return Fibonnachi(m - 1) + Fibonnachi(m - 2);
        }
        else
        {
            return 0;
        }
    }

    public int Sootvetstvie(string s1, string s2)
    {
        int c = 0;
        for (int i = 0; i <= s1.Length - s2.Length; i++)
        {
            if (s1.Substring(i, s2.Length) == s2)
            {
                c++;
            }
        }
        return c;
    }

    public int Primitive(int a)
    {
        if (a <= 1)
        {
            return 0;
        }

        for (int i = 2; i <= Math.Sqrt(Math.Abs(a)); i++)
        {
            if (a % i == 0)
            {
                return 0;
            }
        }
        return 1;
    }

    public int Reverse(int x)
    {
        long revers = 0;
        while (x != 0)
        {
            revers = revers * 10 + x % 10;
            x /= 10;
        }
        if (revers > int.MaxValue || revers < int.MinValue)
        {
            return 0;
        }
        return (int)revers;
    }

    public string RimNum(int num)
    {
        if (num <= 0 || num > 3999)
        {
            return "";
        }

        string rim = "";
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        for (int i = 0; i < 13; i++)
        {
            while (num >= values[i])
            {
                rim += symbols[i];
                num -= values[i];
            }
        }

        return rim;
    }
}


