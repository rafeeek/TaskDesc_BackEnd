using System;
using System.Collections.Generic;

#nullable disable

namespace TaskDesc_BackEnd.Database
{
    public partial class SysUnitsOfMeasure
    {
        public SysUnitsOfMeasure()
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
