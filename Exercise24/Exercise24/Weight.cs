using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    public enum WeightUnit
    {
        Kilogram,
        Pound,
    }
    class Weight
    {
        double _KgWeight { get; set; }
        
        internal void Add(WeightUnit weightUnit, double amount)
        {
            switch(weightUnit)
            {
                case WeightUnit.Kilogram:
                    _KgWeight += amount;
                    break;
                case WeightUnit.Pound:
                    _KgWeight += amount * 0.453592;
                    break;
            }
        }

        internal double GetWeight(WeightUnit weightUnit)
        {
            switch (weightUnit)
            {
                case WeightUnit.Kilogram:
                    return _KgWeight;
                case WeightUnit.Pound:
                    return _KgWeight * 2.20462;
                default:
                    return -1;
            }
        }
    }
}
