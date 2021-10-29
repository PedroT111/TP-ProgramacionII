using CarreraLib.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraSLN.Forms
{
    public partial class FrmConsultarPlanes : Form
    {
        public FrmConsultarPlanes()
        {
            InitializeComponent();
        }

        private async void FrmConsultarPlanes_Load(object sender, EventArgs e)
        {
            await cargarCarrerassAsync();
        }

        private async Task cargarCarrerassAsync()
        {
            string url = "https://localhost:5001/api/Carrera/carreras";
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            List<Carrera> lst = JsonConvert.DeserializeObject<List<Carrera>>(content);

            foreach (Carrera item in lst)
            {
                dgvCarreras.Rows.Add(new object[] { 
                item.IdCarrera,
                item.Nombre
                });
            };

        }
    }
}
