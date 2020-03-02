using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSBlazor.Data.Services.Common;
using VinaC2C.Data.Context;
using VinaC2C.Data.Services.User;
using VinaC2C.MVC.Models;

namespace VinaC2C.MVC.Controllers
{
    public class UserController : Controller
    {

        private readonly VinaC2CContext _context;

        public UserService userService;

        public UserController(VinaC2CContext context)
        {
            this._context = context;
            userService = new UserService(context);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        
        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult Login(UserModel model)
        {
            if(ModelState.IsValid)
            {
                if(userService.LoginByUsernameAndPassword(model.Username,model.Password).Result)
                {
                    return RedirectToAction("Register");
                }
                else
                {
                    ModelState.AddModelError("", "Tên Đăng Nhập Hoặc Mật Khẩu Không Hợp Lệ");
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }
    }
}