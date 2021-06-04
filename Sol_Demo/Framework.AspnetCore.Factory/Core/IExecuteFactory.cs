using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AspnetCore.Factory.Core
{
    public interface IExecuteFactory
    {
        TService Execute<TService>();
    }
}