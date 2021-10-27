using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraLib.Entities
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public List<DetalleCarrera> Detalles { get; set; }

        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();
        }

        public void AddDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }
        public void RemoveDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }
    }
}
