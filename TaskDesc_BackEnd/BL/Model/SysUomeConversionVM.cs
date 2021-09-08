using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskDesc_BackEnd.Database;

namespace TaskDesc_BackEnd.BL.Model
{
    public class SysUomeConversionVM
    {
        public long Uomkey { get; set; }
        public long FromUomkey { get; set; }
        public long ToUomkey { get; set; }
        public decimal UomBaseNbr { get; set; }
        public decimal UomOffsetNbr { get; set; }
        public decimal UomNumeratorNbr { get; set; }
        public decimal UomDenominatorNbr { get; set; }
        public string ConversionFormula { get; set; }

        public virtual SysUnitsOfMeasure FromUomkeyNavigation { get; set; }
    }
}
