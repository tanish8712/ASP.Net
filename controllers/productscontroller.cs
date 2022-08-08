using ASP1.Models;
using ASP1.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP1.controllers
{
    [Route("[controller]")]
    [ApiController]
    public class productscontroller : ControllerBase
    {
        public productscontroller(JsonFileProductService productServices)
        {
            this.ProductService = productServices;
        }

        public JsonFileProductService ProductService { get; }

        public IEnumerable<product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}
