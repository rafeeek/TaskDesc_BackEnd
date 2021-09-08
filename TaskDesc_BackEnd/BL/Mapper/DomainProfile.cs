using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskDesc_BackEnd.BL.Model;
using TaskDesc_BackEnd.Database;

namespace TaskDesc_BackEnd.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<SysUnitsOfMeasure , SysUnitsOfMeasureVM>().ReverseMap();
        }
    }
}
