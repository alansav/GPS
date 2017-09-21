# GPS
This project is a .NET Standard 2.0 class library.

This project is designed to help developers when working with GPS. This provides a class which can store latitude & longitude and can calculate the distance between two GPS positions.

##Usage

`Install-Package GPS`

```
var london = new Savage.GPS.Position(-0.1, 51.52);
var sanFrancisco = new Savage.GPS.Position(-122.45, 37.77);

var distance = london.DistanceFrom(sanFrancisco);
Console.WriteLine($"London is {distance.Kilometers} km from San Francisco");

//Use ConvertKilometersToMiles function to display distance in miles
var miles = Savage.Distance.ConvertKilometersToMiles(distance.Kilometers);
Console.WriteLine($"London is {miles} miles from San Francisco");
```
