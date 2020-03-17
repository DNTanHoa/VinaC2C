using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using VinaC2C.Data.Context;
using VinaC2C.Data.Models;
using VinaC2C.Data.Services.DigitalShop;
using VinaC2C.Data.Services.Feature;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;


namespace VinaC2C.MVC.Controllers
{
    public class DigitalShopController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public DigitalShopService digitalShopService;

        public DigitalShopController(VinaC2CContext context, IWebHostEnvironment environment)
        {
            this._context = context;
            this._environment = environment;
            digitalShopService = new DigitalShopService(context);
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await digitalShopService.GetAllToListAsync());
        }

        public JsonResult Create(DigitalShop shop)
        {
            shop.Initialization(ObjectInitType.Insert, "");
            int result = digitalShopService.Create(shop);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(DigitalShop shop)
        {
            shop.Initialization(ObjectInitType.Update, "");
            int result = digitalShopService.Update(shop.Id, shop);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(DigitalShop shop)
        {
            int result = digitalShopService.Delete(shop.Id);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "eror", note = AppGlobal.DeleteFailMessage });
        }
    }
}