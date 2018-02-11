using ProdcutsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProdcutsApp.Controllers
{
    public class ProdcutsController : ApiController
    {
        Prodcuts[] products = new Prodcuts[]
        {
            new Prodcuts{ Id = 1, Name = "Tomato Soup" },
            new Prodcuts{ Id = 2, Name = "Yo-yo" },
            new Prodcuts{ Id = 3, Name = "Hammer" }
        };

        public IEnumerable<Prodcuts> GetAllProducts()
        {
            return products;
        }

        [HttpPost]
        public Prodcuts Search(Prodcuts p)
        {
            if(p.Id==1)
            {
                return p;
            }
            else
            {
                return new Prodcuts { Id = 2, Name = "else" };
            }
        }
    }
}
