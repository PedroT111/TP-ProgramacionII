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
    public enum Accion
    {
        Create,
        Update,
        Read,
        Delete
    }
    public partial class FrmNuevoPlanEstudio : Form
    {
        private Carrera oCarrera;
        private Accion modo;
        public FrmNuevoPlanEstudio(Accion modo, int nro)
        {
            InitializeComponent();
            oCarrera = new Carrera();
            this.modo = modo;

            if (modo.Equals(Accion.Read))
            {
                CargarPlanEstudioPorId(nro);
                txtAnioCursado.Enabled = false;
                txtCarreraName.Enabled = false;
                txtCuatrimestre.Enabled = false;
                btnAgregar.Enabled = false;
                btnGrabarPlan.Enabled = false;
                dgvDetalles.Enabled = false;
                cboMaterias.Enabled = false;
                this.Text = "Consulta Plan de Estudio";
            }

            if (modo.Equals(Accion.Update))
            {
                this.Text = "Editar Plan de Estudio";
                CargarPlanEstudioPorId(nro);
                cargarInfoPlan();
                ;
            }
            
        }
        private async Task cargarInfoPlan()
        {
            await cargarComboMateriasAsync();
        }

        private async Task CargarPlanEstudioPorId(int nro)
        {
            string url = "https://localhost:5001/api/Carrera/" + nro.ToString();
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            oCarrera= JsonConvert.DeserializeObject<Carrera>(content);

            txtCarreraName.Text = oCarrera.Nombre;
            dgvDetalles.Rows.Clear();
            foreach (DetalleCarrera oDetalle in oCarrera.Detalles)
            {
                dgvDetalles.Rows.Add(new object[] { oDetalle.Materia.IdMateria, oDetalle.Materia.NombreMateria, oDetalle.Cuatrimestre, oDetalle.AnioCursado}); ;
            }
        }
       

        private async void FrmNuevoPlanEstudio_Load(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.Create))
            {
                await cargarComboMateriasAsync();
                await AsignarNumeroCarreraAsync();
                this.Text = "Nuevo Plan de Estudio";
            }
          
        }

        private async Task cargarComboMateriasAsync()
        {
            string url = "https://localhost:5001/api/Carrera/materias";
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            List<Materia> lst = JsonConvert.DeserializeObject<List<Materia>>(content);

            foreach (Materia item in lst)
            {
                cboMaterias.Items.Add(item);
            };

        }

        private async Task AsignarNumeroCarreraAsync()
        {
            string url = "https://localhost:5001/api/Carrera/proximoNro";
            using (HttpClient cliente = new HttpClient())
            {
                var result = await cliente.GetStringAsync(url);
                oCarrera.IdCarrera = Int32.Parse(result);
            }

        }
        private async void btnGrabarPlan_Click(object sender, EventArgs e)
        {
            if (txtCarreraName.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCarreraName.Focus();
                return;
            }
            oCarrera.Nombre = txtCarreraName.Text;
            string data = JsonConvert.SerializeObject(oCarrera);
            if (modo.Equals(Accion.Create))
            {              
                bool success = await crearNuevoPlanAsync(data);
                if (success)
                {
                    MessageBox.Show("Plan de Estudio Registrado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar Plan de Estudio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (modo.Equals(Accion.Update))
            {
                int id = oCarrera.IdCarrera;                
                await EditarPlanEstudioAsync(data, id);                              
            }
            this.Dispose();

        }
         private async Task<bool> EditarPlanEstudioAsync(string data, int id)
         {
             string url = "https://localhost:5001/api/Carrera/carreras" + id.ToString();
             using (HttpClient client = new HttpClient())
             {
                 StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                 var result = await client.PostAsync(url, content);
                 string response = await result.Content.ReadAsStringAsync();
                 return response.Equals("Ok");
             }

         }
        private async Task<bool> crearNuevoPlanAsync(string data)
        {
            string url = "https://localhost:5001/api/Carrera/carreras";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }

        private bool validarCampos()
        {
            if(cboMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una materia", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboMaterias.Focus();
                return false;
            }
           
            if (txtAnioCursado.Text == "")
            {
                MessageBox.Show("Ingrese un año de cursado", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAnioCursado.Focus();
                return false;
            }
            if (txtCuatrimestre.Text == "")
            {
                MessageBox.Show("Ingrese un cuatrimestre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCuatrimestre.Focus();
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Materia oMateria = (Materia)cboMaterias.SelectedItem;
                DetalleCarrera detalle = new DetalleCarrera();

                detalle.AnioCursado = Convert.ToInt32(txtAnioCursado.Text);
                detalle.Cuatrimestre = Convert.ToInt32(txtCuatrimestre.Text);
                detalle.Materia = oMateria;
                oCarrera.AddDetalle(detalle);
                dgvDetalles.Rows.Add(new object[] { oMateria.IdMateria, oMateria.NombreMateria.ToString(), detalle.Cuatrimestre.ToString(), detalle.AnioCursado.ToString() });
            }
        }

        /*private bool ExisteMateriaEnGrilla(string text)
        {
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                if (fila.Cells["materia"].Value.Equals(text))
                    return true;
            }
            return false;
        }*/


        private void dgvDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                oCarrera.RemoveDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    } 
}
