using System.Collections.Generic;

namespace ProjectS.Lands.LandTypes
{
    public class Mountain : ILandType
    {
        public int SoilFertility { get; set; }
        public List<int> Minerals { get; set; }
    }
}
