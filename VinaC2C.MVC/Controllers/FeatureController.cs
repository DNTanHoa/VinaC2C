using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using POSBlazor.Data.Services.Common;
using VinaC2C.Data.Context;
using VinaC2C.Data.Models;
using VinaC2C.Data.Services.Feature;
using VinaC2C.Data.Services.Mail;
using VinaC2C.Data.Services.User;
using VinaC2C.MVC.Models;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;
using VinaC2C.Ultilities.Helpers;

namespace VinaC2C.MVC.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public FeatureService featureService;

        public SendRegisterInforService sendRegisterInforService;

        public FeatureController(VinaC2CContext context, IWebHostEnvironment environment)
        {
            this._context = context;
            this._environment = environment;
            featureService = new FeatureService(context);
            sendRegisterInforService = new SendRegisterInforService();
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await featureService.GetAllToListAsync());
        }

        public JsonResult Create(Feature feature)
        {
            feature.Initialization(ObjectInitType.Insert, "");
            int result = featureService.Create(feature);
            if (result != 0)
                return Json(new { messageType = "Success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "Fail", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(Feature feature)
        {
            feature.Initialization(ObjectInitType.Update, "");
            int result = featureService.Update(feature.Id, feature);
            if (result != 0)
                return Json(new { messageType = "Success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "Fail", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(Feature feature)
        {
            int result = featureService.Delete(feature.Id);
            if (result != 0)
                return Json(new { messageType = "Success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "Fail", note = AppGlobal.DeleteFailMessage });
        }
    }
}