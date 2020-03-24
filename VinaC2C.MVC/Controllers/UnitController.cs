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
    public class UnitController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public UnitService unitService;

        public UnitController(VinaC2CContext context, IWebHostEnvironment environment)
        {
            this._context = context;
            this._environment = environment;
            unitService = new UnitService(context);
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await unitService.GetAllToListAsync());
        }

        public JsonResult Create(Unit unit)
        {
            unit.Initialization(ObjectInitType.Insert, "", HttpContext);
            int result = unitService.Create(unit);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(Unit unit)
        {
            unit.Initialization(ObjectInitType.Update, "", HttpContext);
            int result = unitService.Update(unit.Id, unit);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(Unit unit)
        {
            int result = unitService.Delete(unit.Id);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.DeleteFailMessage });
        }
    }
}