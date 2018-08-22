//**************************************************
//公司: BGI
//作者: ChengL
//描述:
//版本：V1.0.0
//日期：
//**************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Globalization;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCWeb.Models
{
    public class UserInfo
    {
        [Required]
        [Display(Name ="用户名")]
        [StringLength(10,MinimumLength =6)]
        public string UserName { set; get; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(10,MinimumLength =6)]
        [Display(Name ="密  码")]
        public string Password { set; get; }
        [Display(Name ="记住密码")]
        public bool RemeberMe { set; get; }
    }
}