using System.Collections.Generic;

namespace ProjectS.Lands.LandTypes
{
    public class Ocean : ILandType, ISeaLand
    {
        public int SoilFertility { get => 0; set => SoilFertility = 0; }
        public List<int> Minerals { get; set; }
    }
}
