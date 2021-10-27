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
