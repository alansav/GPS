using System;

namespace Savage.GPS
{
    public class LastKnownPosition
    {
        public LastKnownPosition(DateTime? dateLastCaptured, Position position)
        {
            DateLastCaptured = dateLastCaptured ?? DateTime.UtcNow;
            Position = position;
        }

        public readonly DateTime DateLastCaptured;
        public readonly Position Position;
    }
}
