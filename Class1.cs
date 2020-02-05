using System;

public class Class1
{
    var treaters = 250;

    var clearWeather = treaters * 0.10;

    var cloudyWeather = treaters;

    var rainyWeather = treaters * -0.25;

    var fullMoon = treaters * 0.25;

    var fourtyDegrees = treaters * 0.95;

    var fiftyDegrees = treaters;

    var sixtyDegrees = treaters * 0.05;

    var seventyDegrees = treaters * 0.20;

    public int amountTrick(int weather, int degrees)
    {
        var amountCandy = (treaters *3) + weather + degrees;

        return amountCandy;

    }

    Console.WriteLine("")

}
