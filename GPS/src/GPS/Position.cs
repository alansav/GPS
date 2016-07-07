using System;

namespace Savage.GPS
{
    public class Position
    {
        public Position(double longitude, double latitude, Distance accuracy)
        {
            Longitude = longitude;
            Latitude = latitude;
            Accuracy = accuracy;
        }

        public readonly double Longitude;
        public readonly double Latitude;
        public readonly Distance Accuracy;

        public Distance DistanceFrom(Position fromPosition)
        {
            if (fromPosition == null)
                return null;

            //Earth's mean radius is used (6371km) and not the equatorial radius (6378.16)
            double radius = 6371;

            double distanceLongitude = ToRadians(fromPosition.Longitude - Longitude);
            double distanceLatitude = ToRadians(fromPosition.Latitude - Latitude);

            double a = Math.Pow(Math.Sin(distanceLatitude / 2), 2) +
               Math.Cos(ToRadians(Latitude)) * Math.Cos(ToRadians(fromPosition.Latitude)) *
               Math.Pow(Math.Sin(distanceLongitude / 2), 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return Distance.NewFromMeters(radius * c);
        }

        private double ToRadians(double x)
        {
            return x * (Math.PI / 180);
        }

        public string ToString(int decimalPlaces)
        {
            return
                $"{Math.Round(Latitude, decimalPlaces, MidpointRounding.AwayFromZero)}, {Math.Round(Longitude, decimalPlaces, MidpointRounding.AwayFromZero)}";
        }
    }
}
