using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightUnitConverter {
    public class PondUnit : DistanceUnit{
        private static List<PondUnit> units = new List<PondUnit> {
            new PondUnit{Name = "gr",Coefficient = 1},
            new PondUnit{Name = "dr",Coefficient = 1 * 27.34375},
            new PondUnit{Name = "oz",Coefficient = 1 * 27.34375 * 16},
            new PondUnit{Name = "lb",Coefficient = 1 * 27.34375 * 16 * 16},
            new PondUnit{Name = "st",Coefficient = 1 * 27.34375 * 16 * 16 * 14}
        };

        public static ICollection<PondUnit> Units { get { return units; } }

        public double FromGramUnit(GramUnit unit, double value) {
            return (value * unit.Coefficient) / 64.79891 / this.Coefficient;
        }
    }
}
