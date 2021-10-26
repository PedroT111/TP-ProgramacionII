using CarreraLib.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiCarrera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarreraController : ControllerBase
    {
        private IApp app;
        public CarreraController()
        {
            app = new App();
        }


        [HttpGet("materias")]
        public ActionResult GetMaterias()
        {
            return Ok(app.ConsultarMaterias());
        }
        [HttpGet("carreras")]
        public ActionResult GetCarreras()
        {
            return Ok(app.ConsultarCarreras());
        }
    }
}
