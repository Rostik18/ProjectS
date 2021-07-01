using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectS.Lands.LandTypes
{
    public interface ILandType
    {
        [Range(0, 100)]
        public int SoilFertility { get; set; }

        //todo: not int but new abstract class class
        public List<int> Minerals { get; set; }


        // Minerals run out (rather slowly) or fall to the lower limit.
        // Soil fertility decreases during use(for example 1 in 10 years), during non-use is restored(for example 1 in 15 years).
    }
}
