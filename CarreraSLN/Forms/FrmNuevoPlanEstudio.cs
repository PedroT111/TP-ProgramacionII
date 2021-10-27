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
        private Carrera oCarrera;
        public FrmNuevoPlanEstudio()
        {
            InitializeComponent();
            oCarrera = new Carrera();
            
        }
        public enum Accion
        {
            Create,
            Update,
            Read,
            Delete
        }

        private async void FrmNuevoPlanEstudio_Load(object sender, EventArgs e)
        {
            await cargarComboMateriasAsync();
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
                lblnro.Text = "Nro:" + result;
            }

        }
        private async void btnGrabarPlan_Click(object sender, EventArgs e)
        {
            if (txtCarreraName.Text == "")
            {
                MessageBox.Show("Ingrese un nombre de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCarreraName.Focus();
                return;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Ingrese al menos una materia", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            oCarrera.Nombre = txtCarreraName.Text;
            string data = JsonConvert.SerializeObject(oCarrera);
            bool success = await crearNuevoPlanAsync(data);
            if (success)
            {
                MessageBox.Show("Carrera Registrada!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al registrar Carrera!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvDetalles.Rows.Add(new object[] { "", oMateria.NombreMateria, detalle.Cuatrimestre.ToString(), detalle.AnioCursado.ToString()});
            }
        }

        private void dgvDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                oCarrera.RemoveDetalle(dgvDetalles.CurrentRow.Index);
                dgvDetalles.Rows.Remove(dgvDetalles.CurrentRow);
            }

        }
    } 
}
