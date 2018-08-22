using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiServer.Models;
namespace WebApiServer.Controllers
{
    public class WebApiController : ApiController
    {
        private List<Product> lstProducts = new List<Product>() {
            new Product{ Id = 1,Name = "烤肠",Category = "rou",Price = 2},
            new Product{ Id = 2,Name = "羊肉串",Category = "rou",Price = 2.2M},
            new Product{ Id = 3,Name = "烤鸡皮",Category = "ji",Price = 2.5M}
        };
        // GET api/<controller>
        public IEnumerable<Product> GetAllProduct()
        {
            return lstProducts;
        }

        // GET api/<controller>/5
        public Product GetProductByID(int id)
        {
            try
            {
                return lstProducts.Where(x => x.Id == id).First();
            }
            catch
            {
                return new Product();
            }
        }

        // POST api/<controller>
        public IEnumerable<Product> GetProductPrice(string cag)
        {
            try
            {
                return lstProducts.Where(x => x.Category == cag);
            }
            catch
            {
                return new List<Product>();
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}