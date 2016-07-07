using System;
using Xunit;

namespace Savage.GPS
{
    public class LastKnownPositionTests
    {
        public void Constructor_Sets_Properties()
        {
            //Arrange
            var now = DateTime.UtcNow;
            var position = new Position(-0.1, 51.52, Distance.NewFromMeters(5));

            //Act
            var sut = new LastKnownPosition(now, position);

            //Assert
            Assert.Equal(now, sut.DateLastCaptured);
            Assert.Equal(position, sut.Position);
        }
    }
}
