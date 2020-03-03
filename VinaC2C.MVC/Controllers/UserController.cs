using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using POSBlazor.Data.Services.Common;
using VinaC2C.Data.Context;
using VinaC2C.Data.Services.User;
using VinaC2C.MVC.Models;
using VinaC2C.Ultilities.Helpers;

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
        
        public IActionResult Detail()
        {
            return View("Register");
        }

        public async Task<IActionResult> Register(UserModel model)
        {
            if(ModelState.IsValid)
            {
                if (model.Password != model.ConfirmPassword)
                {
                    ModelState.AddModelError("", "Mật Khẩu Xác Nhận Không Khớp");
                    return View("Register");
                }
                else if (userService.IsExistEmail(model.Email).Result)
                {
                    ModelState.AddModelError("", "Email Đã Được Sử Dụng");
                    return View("Register");
                }
                else if (userService.IsExistUsername(model.Username).Result)
                {
                    ModelState.AddModelError("", "Tên Đăng Nhập Đã Được Sử Dụng");
                    return View("Register");
                }
                else
                {
                    //TODO: Send Mail To Active User
                    var registerUser = new Data.Models.User();
                    MapObjectHelper.MapDefault(model, out registerUser);
                    await userService.RegisterUserDefautl(registerUser);
                }
                return View("Index");
            }
            else
                return View("Register");
        }
        
        public IActionResult ResetPassword()
        {
            return View();
        }

        public IActionResult Login(UserModel model)
        {
            if(model != null)
            {
                if(userService.LoginByUsernameAndPassword(model.Username,model.Password).Result)
                {
                    //TODO: Save User Login Infor Cookies
                    return RedirectToAction("Index","Dashboard");
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