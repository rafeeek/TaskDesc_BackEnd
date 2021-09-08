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

        public SysUnitsOfMeasure GetMeasureById(long id);

        public string DeleteMeasure(long id);

        public string UpdateMeasure(SysUnitsOfMeasure Model);
    }
}
