using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Services
{
    public class ServiceFactory: AbstractServiceFactory
    {
        public override IApp crearService()
        {
            return new App();
        }
    }
}
