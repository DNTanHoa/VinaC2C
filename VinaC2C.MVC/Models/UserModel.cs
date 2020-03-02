using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using VinaC2C.Data.Models;

namespace VinaC2C.MVC.Models
{
    public class UserModel : BaseModel
    {
        [Required(ErrorMessage = "Tên Đăng Nhập Không Được Để Trống")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Mật Khẩu Không Được Để Trống")]
        public string Password { get; set; }
        
        public string Fullname { get; set; }
        
        public string Phone { get; set; }
        
        public string Email { get; set; }
    }
}
