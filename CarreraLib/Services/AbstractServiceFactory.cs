using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Services
{
    public abstract class AbstractServiceFactory
    {
        public abstract IApp crearService();
    }
}
