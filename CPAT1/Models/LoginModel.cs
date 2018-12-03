using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

    //CODE WRITTEN BY JOSHUA FARIA

namespace CPAT1.Models
{
    public class LoginModel : Controller
    {
        // GET: /<controller>/

        [Required]
        public string uname { get; set; }

        [Required]
        public string psw { get; set; }

        public string ReturnUrl { get; set; } = "/";
    }
}
