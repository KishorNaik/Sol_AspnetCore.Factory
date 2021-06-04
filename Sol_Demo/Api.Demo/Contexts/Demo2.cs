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