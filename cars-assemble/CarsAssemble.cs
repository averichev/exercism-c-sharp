using System;

static class AssemblyLine
{
    private const byte EachHour = 221;

    private static double Percent(int speed)
    {
        if (speed >= 1 && speed <= 4)
        {
            return 100;
        }

        if (speed >= 5 && speed <= 8)
        {
            return 90;
        }

        if (speed == 9)
        {
            return 80;
        }

        if (speed == 10)
        {
            return 77;
        }

        return 0;
    }

    public static double SuccessRate(int speed)
    {
        return Percent(speed) / 100;
    }

    public static double ProductionRatePerHour(int speed)
    {
        var rate = SuccessRate(speed);
        return EachHour * speed * rate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        var result = ProductionRatePerHour(speed) / 60;
        return (int) result;
    }
}