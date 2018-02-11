using ProdcutsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProdcutsApp.Controllers
{
    public class SearchController : ApiController
    {
        [HttpPost]
        public string Search(Prodcuts p)
        {
            if (p.Id == 1)
            {
                return p.Name;
            }
            else
            {
                return "else";
            }
        }
    }
}
