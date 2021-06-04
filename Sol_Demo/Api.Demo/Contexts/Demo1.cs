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

        int Test { get; set; }
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