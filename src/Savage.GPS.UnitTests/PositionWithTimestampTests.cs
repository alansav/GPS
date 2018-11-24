using System;
using Xunit;

namespace Savage.GPS
{
    public class PositionWithTimestampTests
    {
        [Fact]
        public void Constructor_Sets_Properties()
        {
            //Arrange
            var now = DateTime.UtcNow;
            var position = new Position(-0.1, 51.52, new Measurements.Distance(5, Measurements.UnitsOfMeasure.Distances.Meters));

            //Act
            var sut = new PositionWithTimestamp(position, now);

            //Assert
            Assert.Equal(now, sut.Timestamp);
            Assert.Equal(position, sut.Position);
        }

        [Fact]
        public void Constructor_Sets_Properties_When_Timestamp_Not_Provided()
        {
            //Arrange
            var now = DateTime.UtcNow;
            var position = new Position(-0.1, 51.52, new Measurements.Distance(5, Measurements.UnitsOfMeasure.Distances.Meters));

            //Act
            var sut = new PositionWithTimestamp(position);
            
            //Assert
            Assert.InRange(sut.Timestamp, now, DateTime.UtcNow);
            Assert.Equal(position, sut.Position);
        }
    }
}
