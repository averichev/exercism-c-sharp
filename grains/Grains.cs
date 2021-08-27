using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n <= 0 || n > 64)
        {
            throw new ArgumentOutOfRangeException();
        }

        var result = 1UL;

        for (int counter = 1; counter < n; counter++)
        {
            result *= 2;
        }

        return result;
    }

    public static ulong Total()
    {
        const int square = 64;
        var result = 0UL;
        for (int i = 1; i <= square; i++)
        {
            var quantity = Square(i);
            result += quantity;
        }
        return result;
    }
}