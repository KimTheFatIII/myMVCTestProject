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

namespace WebApiServer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}