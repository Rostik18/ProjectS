using ProjectS.Lands.Abstractions;
using ProjectS.Lands.LandTypes;

namespace ProjectS.Lands
{
    public class Land : ILandPoint
    {
        public int X { get; init; }
        public int Y { get; init; }

        public ILandType LandType { get; init; }

        public Land(int x, int y, ILandType landType)
        {
            X = x;
            Y = y;
            LandType = landType;
        }

    }
}
