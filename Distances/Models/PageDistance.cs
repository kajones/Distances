using System;

namespace Distances.Models
{
    public class PageDistance
    {
        public decimal[] RowValue { get; set; }

        public PageDistance()
        {
            RowValue = new decimal[7];{}
        }

        public void SetValue(int pos, decimal value, Unit unit)
        {
            RowValue[pos] = GetValueInMiles(value, unit);
        }

        private static decimal GetValueInMiles(decimal value, Unit unit)
        {
            switch (unit)
            {
                case Unit.Mile:
                    return value;
                case Unit.Chain:
                    return value * 0.0125M;
                case Unit.Fathom:
                    return value*0.001136M;
                case Unit.Foot:
                    return value*0.000189M;
                case Unit.Furlong:
                    return value*0.125M;
                case Unit.Inch:
                    return value*1/63360;
                case Unit.Yard:
                    return value*0.000568182M;
                case Unit.Rod:
                    return value*0.003125M;
                default: throw new Exception($"Unrecognised unit ({unit})");
            }
        }
    }
}
