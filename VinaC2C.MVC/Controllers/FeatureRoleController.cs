using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using VinaC2C.Data.Context;
using VinaC2C.Data.Models;
using VinaC2C.Data.Services.Feature;
using VinaC2C.MVC.ServerHub;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;
using VinaC2C.Ultilities.Extensions;

namespace VinaC2C.MVC.Controllers
{
    public class FeatureRoleController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public FeatureRoleService featureRoleService;

        private IHubContext<SignalServer> _hubContext;

        public FeatureRoleController(VinaC2CContext context, IWebHostEnvironment environment, IHubContext<SignalServer> hubContext)
        {
            this._context = context;
            this._environment = environment;
            this._hubContext = hubContext;
            featureRoleService = new FeatureRoleService(context);
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await featureRoleService.GetAllToListAsync());
        }

        public JsonResult Create(FeatureRole featureRole)
        {
            featureRole.Initialization(ObjectInitType.Insert, "");
            int result = featureRoleService.Create(featureRole);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(FeatureRole featureRole)
        {
            featureRole.Initialization(ObjectInitType.Update, "");
            int result = featureRoleService.Update(featureRole.Id, featureRole);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(FeatureRole featureRole)
        {
            int result = featureRoleService.Delete(featureRole.Id);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.DeleteFailMessage });
        }

    }
}