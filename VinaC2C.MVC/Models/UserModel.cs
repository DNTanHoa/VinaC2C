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
        [Required(ErrorMessage = "Không Được Để Trống")]
        public string Username { get; set; }
        
        [Required(ErrorMessage = "Không Được Để Trống")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Không Được Để Trống")]
        public string ConfirmPassword { get; set; }
        
        [Required(ErrorMessage = "Không Được Để Trống")]
        public string Fullname { get; set; }
        
        [Required(ErrorMessage = "Không Được Để Trống")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Không Hợp Lệ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Không Được Để Trống")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Không Hợp Lệ")]
        public string Email { get; set; }

        
    }
}
