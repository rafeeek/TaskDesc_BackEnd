using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskDesc_BackEnd.Database;

namespace TaskDesc_BackEnd.BL.Model
{
    public class SysUnitsOfMeasureVM
    {
        public SysUnitsOfMeasureVM()
        {
            SysUomeConversions = new HashSet<SysUomeConversion>();
        }

        public long Uomkey { get; set; }
        public string UomeCateg { get; set; }
        public string UomeId { get; set; }
        public string UomeDesc { get; set; }
        public string UomeCaption { get; set; }
        public string UomeSysFlg { get; set; }
        public string UmcsId { get; set; }

        public virtual ICollection<SysUomeConversion> SysUomeConversions { get; set; }
    }
}
