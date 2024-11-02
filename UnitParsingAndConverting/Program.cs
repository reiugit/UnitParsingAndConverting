using UnitsNet;
using UnitsNet.Units;
using static System.Console;

// Speed Examples
WriteLine("==== Speed Examples ============");

var speed = Speed.FromKilometersPerHour(100);
WriteLine($"\n     Speed: {speed}");

speed = speed.ToUnit(SpeedUnit.MilePerHour);
WriteLine($"\n     Speed: {speed}");

WriteLine($"     Value: {speed.Value}");
WriteLine($"     Unit:  {speed.Unit}");

WriteLine($"\n     MetersPerSecond: {speed.MetersPerSecond}");

// Temperature Examples
WriteLine("\n==== Temperature Examples ====");

var tempString = "20 °C";
var temperature = Temperature.Parse(tempString);
WriteLine($"\n     Temperature: {temperature}");

temperature = temperature.ToUnit(TemperatureUnit.DegreeFahrenheit);
WriteLine($"     Temperature: {temperature}");

WriteLine($"\n     DegreesDelisle: {temperature.DegreesDelisle}");
WriteLine($"     Unit: {TemperatureUnit.DegreeDelisle}");

WriteLine("\n===============================");
