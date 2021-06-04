using Api.Demo.Contexts;
using Framework.AspnetCore.Factory.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/demo")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IExecuteFactory executeFactory = null;

        public DemoController(IExecuteFactory executeFactory)
        {
            this.executeFactory = executeFactory;
        }

        [HttpGet("demo1")]
        public IActionResult Demo1()
        {
            var response = executeFactory.Execute<IDemo1>();

            response.Test = 10;

            return base.Ok(response);
        }

        [HttpGet("demo2")]
        public IActionResult Demo2()
        {
            var response = (executeFactory.Execute<IDemo2>()).TestDemo();

            var response1 = executeFactory.Execute<IDemo1>();

            return base.Ok(response);
        }
    }
}