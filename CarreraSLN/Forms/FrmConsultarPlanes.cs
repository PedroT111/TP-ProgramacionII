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

        private async Task EliminarCarrerasAsync(int id)
        {
            string url = "https://localhost:5001/api/Carrera/" + id.ToString();
            HttpClient client = new HttpClient();
            var result = await client.DeleteAsync(url);
            var responseContent = await result.Content.ReadAsStringAsync();

        }

        private async void dgvCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCarreras.CurrentCell.ColumnIndex == 2)
            {
                int nro = Convert.ToInt32(dgvCarreras.CurrentRow.Cells["nro_carrera"].Value.ToString());
                FrmNuevoPlanEstudio form = new FrmNuevoPlanEstudio(Accion.Read, nro);
                form.ShowDialog();
            }
            if(dgvCarreras.CurrentCell.ColumnIndex == 3)
            {
                int nro = Convert.ToInt32(dgvCarreras.CurrentRow.Cells["nro_carrera"].Value.ToString());
                FrmNuevoPlanEstudio form = new FrmNuevoPlanEstudio(Accion.Update, nro);
                form.ShowDialog();
            }
            if (dgvCarreras.CurrentCell.ColumnIndex == 4)
            {
                int nro = Convert.ToInt32(dgvCarreras.CurrentRow.Cells["nro_carrera"].Value.ToString());
                if (MessageBox.Show("Seguro que desea eliminar el presupuesto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await EliminarCarrerasAsync(nro);
                    dgvCarreras.Rows.Remove(dgvCarreras.CurrentRow);
                }        

              
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
