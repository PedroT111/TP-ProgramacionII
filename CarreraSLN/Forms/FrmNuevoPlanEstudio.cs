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
    public partial class FrmNuevoPlanEstudio : Form
    {
        public FrmNuevoPlanEstudio()
        {
            InitializeComponent();
        }

        private async void FrmNuevoPlanEstudio_Load(object sender, EventArgs e)
        {
            await cargarComboMateriasAsync();
        }

        private async Task cargarComboMateriasAsync()
        {
            string url = "https://localhost:5001/api/Carrera/materias";
            HttpClient client= new HttpClient();
            var result  = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            List<Materia> lst = JsonConvert.DeserializeObject<List<Materia>>(content);

            foreach(Materia item in lst)
            {
                cboMaterias.Items.Add(item);
            };

        }
    }
}
