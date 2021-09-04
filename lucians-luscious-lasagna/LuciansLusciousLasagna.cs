class Lasagna
{
    private const int Time = 40;
    private const int TimeForOneLayer = 2;

    public int ExpectedMinutesInOven()
    {
        return Time;
    }

    public int RemainingMinutesInOven(int current)
    {
        return Time - current;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * TimeForOneLayer;
    }

    public int ElapsedTimeInMinutes(int layers, int minutes)
    {
        return PreparationTimeInMinutes(layers) + minutes;
    }
}