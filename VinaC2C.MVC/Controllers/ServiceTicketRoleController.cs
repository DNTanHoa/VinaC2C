using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using VinaC2C.Data.Context;
using VinaC2C.Data.DataTransferObject;
using VinaC2C.Data.Models;
using VinaC2C.Data.Services.DigitalShop;
using VinaC2C.Data.Services.Feature;
using VinaC2C.Data.Services.User;
using VinaC2C.MVC.Models;
using VinaC2C.MVC.ServerHub;
using VinaC2C.Ultilities.AppInfor;
using VinaC2C.Ultilities.Enums;
using VinaC2C.Ultilities.Extensions;

namespace VinaC2C.MVC.Controllers
{
    public class ServiceTicketRoleController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public ServiceTicketRoleService serviceTicketRoleService;
        public UserService userService;

        private IHubContext<SignalServer> _hubContext;

        public ServiceTicketRoleController(VinaC2CContext context, IWebHostEnvironment environment, IHubContext<SignalServer> hubContext)
        {
            this._context = context;
            this._environment = environment;
            this._hubContext = hubContext;
            serviceTicketRoleService = new ServiceTicketRoleService(context);
            userService = new UserService(context);
        }

        public async Task<IActionResult> Index()
        {
            var model = new ServiceTicketRoleModel();
            model.users = await userService.GetForSelectList();
            model.userOptions = new SelectList(model.users, nameof(UserSelect.ID), nameof(UserSelect.DisplayName));
            return View(model);
        }
        
        #region Default
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await serviceTicketRoleService.GetAllToListAsync());
        }

        public JsonResult Create(ServiceTicketRole service)
        {
            service.Initialization(ObjectInitType.Insert, "");
            int result = serviceTicketRoleService.Create(service);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(ServiceTicketRole service)
        {
            service.Initialization(ObjectInitType.Update, "");
            int result = serviceTicketRoleService.Update(service.Id, service);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(ServiceTicketRole service)
        {
            int result = serviceTicketRoleService.Delete(service.Id);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.DeleteFailMessage });
        }
        #endregion

        public JsonResult GetServiceTicketByUsername(string username)
        {
            return Json(serviceTicketRoleService.GetServiceTicketByUsername(username));
        }

        public JsonResult InitializeUserServiceTicketRole()
        {
            return Json(serviceTicketRoleService.InitializeUserServiceTicketRole());
        }
    }
}