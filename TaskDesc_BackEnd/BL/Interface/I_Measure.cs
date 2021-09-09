using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskDesc_BackEnd.Database;

namespace TaskDesc_BackEnd.BL.Interface
{
    public interface I_Measure
    {
        public bool AddNewMeasure(SysUnitsOfMeasure Model);

        public IEnumerable<SysUnitsOfMeasure> GetAllMeasure();

        public IEnumerable<SysUnitsOfMeasure> GetMeasureByCaption(string Caption);

        public string DeleteMeasure(long id);

        public bool UpdateMeasure(SysUnitsOfMeasure Model);

        public IEnumerable<string> DistinctList();
    }
}
