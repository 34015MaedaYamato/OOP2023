using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeightUnitConverter {
    public class GramUnit : DistanceUnit{
        private static List<GramUnit> units = new List<GramUnit> {
            new GramUnit{Name = "mg",Coefficient = 1},
            new GramUnit{Name = "g",Coefficient = 1000},
            new GramUnit{Name = "kg",Coefficient = 1000 * 1000},
            new GramUnit{Name = "t",Coefficient = 1000 * 1000 * 1000},
            
        };

        public static ICollection<GramUnit> Units { get { return units; } }

        public double FromPondUnit(PondUnit unit, double value) {
            return (value * unit.Coefficient) * 64.79891 / this.Coefficient;
        }
    }
}
