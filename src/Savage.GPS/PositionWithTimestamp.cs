using System;

namespace Savage.GPS
{
    public class PositionWithTimestamp
    {
        public PositionWithTimestamp(Position position, DateTime? timestamp = null)
        {
            Timestamp = timestamp ?? DateTime.UtcNow;
            Position = position;
        }

        public readonly DateTime Timestamp;
        public readonly Position Position;
    }
}
