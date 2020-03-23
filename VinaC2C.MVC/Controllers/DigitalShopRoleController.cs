using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using VinaC2C.Data.Context;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Data.Models;
using VinaC2C.Data.Services.DigitalShop;
using VinaC2C.Data.Services.Feature;
using VinaC2C.Data.Services.User;
using VinaC2C.MVC.Models;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;


namespace VinaC2C.MVC.Controllers
{
    public class DigitalShopRoleController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public DigitalShopRoleService digitalShopRoleService;
        public UserService userService;

        public DigitalShopRoleController(VinaC2CContext context, IWebHostEnvironment environment)
        {
            this._context = context;
            this._environment = environment;
            digitalShopRoleService = new DigitalShopRoleService(context);
            userService = new UserService(context);
        }

        public async Task<IActionResult> Index()
        {
            var model = new DigitalShopRoleModel();
            model.users = await userService.GetForSelectList();
            model.userOptions = new SelectList(model.users, nameof(UserSelect.ID), nameof(UserSelect.DisplayName));
            return View(model);
        }
        
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await digitalShopRoleService.GetAllToListAsync());
        }

        public JsonResult Create(DigitalShopRole role)
        {
            role.Initialization(ObjectInitType.Insert, "");
            int result = digitalShopRoleService.Create(role);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(DigitalShopRole role)
        {
            role.Initialization(ObjectInitType.Update, "");
            int result = digitalShopRoleService.Update(role.Id, role);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(DigitalShopRole role)
        {
            int result = digitalShopRoleService.Delete(role.Id);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.DeleteFailMessage });
        }

        public JsonResult GetDigitalShopByUsername(string username)
        {
            return Json(digitalShopRoleService.GetDigitalShopByUsername(username));
        }

        public JsonResult InitializeUserDigitalShopRole()
        {
            return Json(digitalShopRoleService.InitializeUserDigitalShopRole());
        }
    }
}