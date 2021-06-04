# Asp.net Core Factory.
A Library for implement the factory method in asp.net core.

### Step 1
Add following nuget package in your asp.net core Solution.
[![Generic badge](https://img.shields.io/badge/Nuget-1.0.0-<COLOR>.svg)](https://www.nuget.org/packages/Framework.AspnetCore.Factory/1.0.0)

#### Using Nuget Package Manger:
```
PM> Install-Package Framework.AspnetCore.Factory -Version 1.0.0
```

#### Using .Net CLI:
```
> dotnet add package Framework.AspnetCore.Factory --version 1.0.0
```
#### Using .Net CLI:
```
<PackageReference Include="Framework.AspnetCore.Factory" Version="1.0.0" />
```



### Step 2
Create a Services classes.
```C#
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Demo.Contexts
{
    public interface IDemo1
    {
        String TestDemo();
    }

    public class Demo1 : IDemo1
    {
        String IDemo1.TestDemo()
        {
            Debug.WriteLine("Demo 1");
            return "Demo 1";
        }

        public int Test { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Demo.Contexts
{
    public interface IDemo2
    {
        String TestDemo();
    }

    public class Demo2 : IDemo2
    {
        String IDemo2.TestDemo()
        {
            Debug.WriteLine("Demo 2");
            return "Demo 2";
        }
    }
}
```

### Step 3
Go to Startup.cs file, In the ConfigureService method add the following services.
```C#
services.AddFactory((x) =>
{
    x.AddTransient<IDemo1, Demo1>();
    x.AddSingleton<IDemo2, Demo2>();
    
     // Or using fluent
      //x.AddTransient<IDemo1, Demo1>()
      // .AddSingleton<IDemo2, Demo2>();
});
```

Full ConfigureService Method Code.
```C#
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();

    services.AddFactory((x) =>
    {
        x.AddTransient<IDemo1, Demo1>();
        x.AddSingleton<IDemo2, Demo2>();
        
        // Or using fluent
        //x.AddTransient<IDemo1, Demo1>()
        // .AddSingleton<IDemo2, Demo2>();
    });

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Api.Demo", Version = "v1" });
    });
}
```

### Step 4
Inject factory in the controller class.
```C#
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
            var response = executeFactory.Execute<IDemo1>().TestDemo();

            return base.Ok(response);
        }

        [HttpGet("demo2")]
        public IActionResult Demo2()
        {
            var response = (executeFactory.Execute<IDemo2>()).TestDemo();

            return base.Ok(response);
        }
    }
}
```

