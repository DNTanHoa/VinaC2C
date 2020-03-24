using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using VinaC2C.Data.Context;
using VinaC2C.Data.Models;
using VinaC2C.Data.Services;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;


namespace VinaC2C.MVC.Controllers
{
    [Authorize]
    public class UnitConvertController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public UnitConvertService unitConvertService;

        public UnitConvertController(VinaC2CContext context, IWebHostEnvironment environment)
        {
            this._context = context;
            this._environment = environment;
            unitConvertService = new UnitConvertService(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Default
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await unitConvertService.GetAllToListAsync());
        }

        public JsonResult Create(UnitConvert unitConvert)
        {
            unitConvert.Initialization(ObjectInitType.Insert, "", HttpContext);
            int result = unitConvertService.Create(unitConvert);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(UnitConvert unitConvert)
        {
            unitConvert.Initialization(ObjectInitType.Update, "", HttpContext);
            int result = unitConvertService.Update(unitConvert.Id, unitConvert);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(UnitConvert unitConvert)
        {
            int result = unitConvertService.Delete(unitConvert.Id);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.DeleteFailMessage });
        }
        #endregion
    }
}