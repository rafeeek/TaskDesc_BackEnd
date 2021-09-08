using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskDesc_BackEnd.BL.Helper;
using TaskDesc_BackEnd.BL.Interface;
using TaskDesc_BackEnd.BL.Model;
using TaskDesc_BackEnd.Database;

namespace TaskDesc_BackEnd.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysUnitsOfMeasureController : ControllerBase
    {
        private readonly I_Measure measure;
        private readonly IMapper mapper;
        private readonly Response response;

        #region Ctor
        public SysUnitsOfMeasureController(I_Measure Measure , IMapper Mapper)
        {
            measure = Measure;
            mapper = Mapper;
        }
        #endregion


        #region APIs

        [HttpPost]
        [Route("AddNew")]
        public Response AddMeasure([FromBody] SysUnitsOfMeasureVM model)
        {
            var data = mapper.Map<SysUnitsOfMeasure>(model);
            data.Uomkey = GetHashCode();
            var result = measure.AddNewMeasure(data);

            Response response = new Response()
            {
                Massage = result ? "Added" : "Not Added"
            };
            return response;
        }
            
        #endregion
    }
}
