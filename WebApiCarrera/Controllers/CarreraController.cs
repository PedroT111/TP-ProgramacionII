using CarreraLib.Entities;
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
            //AbstractServiceFactory factory = new ServiceFactory();
            //app = factory.crearService();
            app = new App();
        }

        [HttpGet("materias")]
        public ActionResult GetMaterias()
        {
            return Ok(app.ConsultarMaterias());
        }
        [HttpPost("materias")]
        public ActionResult PostMateria(Materia oMateria)
        {
            if (oMateria == null)
                return BadRequest();
            if (app.CrearMateria(oMateria))
                return Ok("Ok");
            else
                return Ok("No se pudo grabar la materia");
        }

        [HttpGet("carreras")]
        public ActionResult GetCarreras()
        {
            return Ok(app.ConsultarCarreras());
        }

       /* [HttpGet("carreras")]
        public ActionResult GetPlanDeEstudioPorId()
        {
            return Ok(app.ConsultarPlanPorId());
        }*/

        [HttpPost("carreras")]
        public ActionResult PostCarrera(Carrera oCarrera)
        {
            if (oCarrera == null)
                return BadRequest();
            if (app.CrearCarrera(oCarrera))
                return Ok("Ok");
            else
                return Ok("No se pudo grabar la carrera");
        }
        [HttpGet("proximoNro")]
        public string GetProximoNroCarera()
        {
            return app.getProximoIdCarrera().ToString();
        }

    }
}
