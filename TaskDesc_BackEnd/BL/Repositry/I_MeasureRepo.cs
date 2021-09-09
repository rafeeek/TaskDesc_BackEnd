using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskDesc_BackEnd.BL.Interface;
using TaskDesc_BackEnd.Database;

namespace TaskDesc_BackEnd.BL.Repositry
{
    public class I_MeasureRepo : I_Measure
    {
        private readonly TestContext context;

        #region Ctor
        public I_MeasureRepo(TestContext Context)
        {
            context = Context;
        }
        #endregion


        #region Curd

        public bool AddNewMeasure(SysUnitsOfMeasure Model)
        {
            try
            {
                context.SysUnitsOfMeasures.Add(Model);
                int result = context.SaveChanges();
                bool addingResult = result > 0;
                return addingResult;
            }
            catch (Exception ex)
            {
               throw;
            }
        }

        public string DeleteMeasure(long id)
        {
            try
            {
                var Model = context.SysUnitsOfMeasures.Where(a=> a.Uomkey ==  id).FirstOrDefault();
                context.SysUnitsOfMeasures.Remove(Model);
                context.SaveChanges();
                return "Measure Deleted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<SysUnitsOfMeasure> GetAllMeasure()
        {
            try
            {
                var Data = context.SysUnitsOfMeasures.Select(a => a);
                return Data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<SysUnitsOfMeasure> GetMeasureByCaption(string Caption)
        {
            try
            {
                var Model = context.SysUnitsOfMeasures.Where(a => a.UomeCaption == Caption);
                return Model;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool UpdateMeasure(SysUnitsOfMeasure Model)
        {
            try
            {
                context.Entry(Model).State = EntityState.Modified;
                int result = context.SaveChanges();
                bool addingResult = result > 0;
                return addingResult;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<string> DistinctList()
        {
            try
            {
                var data = context.SysUnitsOfMeasures.Select(a => a.UomeCaption).Distinct();
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

    }
}
