using Framework.AspnetCore.Factory.Core.Scoped;
using Framework.AspnetCore.Factory.Core.Singleton;
using Framework.AspnetCore.Factory.Core.Transient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.AspnetCore.Factory.Core
{
    public interface IRegisterFactory : ISingleton, ITransient, IScoped
    {
    }
}