using System;
using Xunit;

namespace Savage.GPS
{
    public class GpsTests
    {
        readonly Position _london = new Position(-0.1, 51.52, new Measurements.Distance(0, Measurements.UnitsOfMeasure.Distances.Meters));
        readonly Position _sanFrancisco = new Position(-122.45, 37.77, new Measurements.Distance(0, Measurements.UnitsOfMeasure.Distances.Meters));
        readonly Position _tokyo = new Position(139.77, 35.67, new Measurements.Distance(0, Measurements.UnitsOfMeasure.Distances.Meters));
        readonly Position _sydney = new Position(151.21, -33.87, new Measurements.Distance(0, Measurements.UnitsOfMeasure.Distances.Meters));
        readonly Position _paris = new Position(2.34, 48.86, new Measurements.Distance(0, Measurements.UnitsOfMeasure.Distances.Meters));

        [Fact]
        public void LondonToSanFrancisco()
        {
            double distance = _london.DistanceFrom(_sanFrancisco).Value;
            Assert.Equal(8619, Math.Round(distance, 0));
        }

        [Fact]
        public void LondonToTokyo()
        {
            double distance = _london.DistanceFrom(_tokyo).Value;
            Assert.Equal(9561, Math.Round(distance, 0));
        }

        [Fact]
        public void LondonToSydney()
        {
            double distance = _london.DistanceFrom(_sydney).Value;
            Assert.Equal(16992, Math.Round(distance, 0));
        }

        [Fact]
        public void LondonToParis()
        {
            double distance = _london.DistanceFrom(_paris).Value;
            Assert.Equal(343, Math.Round(distance, 0));
        }

        [Fact]
        public void SydneyToLondon()
        {
            double distance = _sydney.DistanceFrom(_london).Value;
            Assert.Equal(16992, Math.Round(distance, 0));
        }

        [Fact]
        public void SydneyToTokyo()
        {
            double distance = _sydney.DistanceFrom(_tokyo).Value;
            Assert.Equal(7823, Math.Round(distance, 0));
        }

        [Fact]
        public void SydneyToSanFrancisco()
        {
            double distance = _sydney.DistanceFrom(_sanFrancisco).Value;
            Assert.Equal(11945, Math.Round(distance, 0));
        }

        [Fact]
        public void Returns_Null_When_Position_Is_Null()
        {
            //Act
            var sut = _london.DistanceFrom(null);

            //Assert
            Assert.Null(sut);
        }

        [Fact]
        public void Test_To_string()
        {
            //Act
            var sut = _sanFrancisco.ToString(1);

            Assert.Equal("37.8, -122.5", sut);
        }
    }
}
