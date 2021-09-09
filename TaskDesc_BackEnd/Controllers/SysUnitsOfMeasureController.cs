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

        #region Ctor
        public SysUnitsOfMeasureController(I_Measure Measure , IMapper Mapper)
        {
            measure = Measure;
            mapper = Mapper;
        }
        #endregion

        #region APIs
        //[EnableQuery]

        [HttpPost]
        [Route("AddNew")]
        public Response AddMeasure([FromBody] SysUnitsOfMeasureVM model)
        {
            var data = mapper.Map<SysUnitsOfMeasure>(model);
            data.Uomkey = GetHashCode();
            var result = measure.AddNewMeasure(data);

            Response response = new Response()
            {
                Massage = result ? "New Measures Added" : "Not Added"
            };
            return response;
        }

        [HttpGet]
        [Route("DistinctList")]
        public ActionResult<IEnumerable<string>> DistinctList()
        {
            var data = measure.DistinctList();
            return Ok(data);
        }

        [HttpGet]
        [Route("AllMeasure")]
        public ActionResult<IEnumerable<SysUnitsOfMeasureVM>> AllMeasure()
        {
            var data = measure.GetAllMeasure();
            var dataVM = mapper.Map<IEnumerable<SysUnitsOfMeasureVM>>(data);
            return Ok(dataVM);
        }

        [HttpGet]
        [Route("GetMeasures")]
        public IEnumerable<SysUnitsOfMeasureVM> GetMeasures(string Caption)
        {
            var data = measure.GetMeasureByCaption(Caption);
            var dataVM = mapper.Map<IEnumerable<SysUnitsOfMeasureVM>>(data);
            return dataVM;
        }

        [HttpPatch]
        [Route("UpdateMeasures")]
        public Response UpdateMeasures([FromBody] SysUnitsOfMeasureVM obj)
        {
            var result = measure.UpdateMeasure(mapper.Map<SysUnitsOfMeasure>(obj));

            Response response = new Response()
            {
                Massage = result ? "Update One Measure" : "Not Update"
            };
            return response;
        }

        #endregion
    }
}
