using System;
using static System.String;

class RemoteControlCar
{
    private float _distance = 0;
    private float _battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        return _battery == 0 ? "Battery empty" : $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (!(_battery > 0)) return;
        _distance += 20;
        _battery -= 1;
    }
}
