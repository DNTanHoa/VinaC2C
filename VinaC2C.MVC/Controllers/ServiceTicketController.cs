using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using VinaC2C.Data.Context;
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
    public class ServiceTicketController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        private readonly VinaC2CContext _context;

        public ServiceTicketService serviceTicketService;

        private IHubContext<SignalServer> _hubContext;

        public ServiceTicketController(VinaC2CContext context, IWebHostEnvironment environment, IHubContext<SignalServer> hubContext)
        {
            this._context = context;
            this._environment = environment;
            this._hubContext = hubContext;
            serviceTicketService = new ServiceTicketService(context);
        }

        public IActionResult Index()
        {
            return View();
        }
        
        #region Default
        public async Task<JsonResult> GetAllAsyncToList()
        {
            return Json(await serviceTicketService.GetAllToListAsync());
        }

        public JsonResult Create(ServiceTicket service)
        {
            service.Initialization(ObjectInitType.Insert, "");
            int result = serviceTicketService.Create(service);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.InsertSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.InsertFailMessage });
        }

        public JsonResult Update(ServiceTicket service)
        {
            service.Initialization(ObjectInitType.Update, "");
            int result = serviceTicketService.Update(service.Id, service);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.UpdateSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.UpdateFailMessage });
        }

        public JsonResult Delete(ServiceTicket service)
        {
            int result = serviceTicketService.Delete(service.Id);
            _hubContext.Clients.All.SendAsync("dataChangeNotification", null);
            if (result != 0)
                return Json(new { messageType = "success", note = AppGlobal.DeleteSuccessMessage });
            else
                return Json(new { messageType = "error", note = AppGlobal.DeleteFailMessage });
        }
        #endregion

        

    }
}