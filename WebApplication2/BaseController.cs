using Common.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace WebApplication2
{
    [Route("api/[controller]")]
    public class BaseController<T> : Controller where T : class, new()
    {
        public BaseController()
        {
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            return null;
        }

        //[HttpGet("{id}")]
        //public T Get(Guid id)
        //{
        //    return null;
        //}

        [HttpPost]
        public void Post( [FromBody]ClientRequest<T> value)
        { 
        }
    }
}


