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
                btnAgregar.Enabled = false;
                btnGrabarPlan.Enabled = false;
                //Cargar presupuesto por nro
            }
            
        }
       

        private async void FrmNuevoPlanEstudio_Load(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.Create))
            {
                await cargarComboMateriasAsync();
                await AsignarNumeroCarreraAsync();
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
            /*if (dgvDetalles.RowCount == 0)
            {
                MessageBox.Show("Debe ingresar al menos una materia", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMaterias.Focus();
                return;
            }*/ //No funciona
            if (txtCarreraName.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese un nombre de carrera", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCarreraName.Focus();
                return;
            }
            oCarrera.Nombre = txtCarreraName.Text;
            string data = JsonConvert.SerializeObject(oCarrera);
            bool success = await crearNuevoPlanAsync(data);
            if (success)
            {
                MessageBox.Show("Plan de Estudio Registrado!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error al registrar Plan de Estudio!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
               /* if (MateriaExists(cboMaterias.Text))
                {
                    MessageBox.Show("Ya existe esa materia en el plan", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }*/
               
                Materia oMateria = (Materia)cboMaterias.SelectedItem;
                DetalleCarrera detalle = new DetalleCarrera();

                detalle.AnioCursado = Convert.ToInt32(txtAnioCursado.Text);
                detalle.Cuatrimestre = Convert.ToInt32(txtCuatrimestre.Text);
                detalle.Materia = oMateria;
                oCarrera.AddDetalle(detalle);
                dgvDetalles.Rows.Add(new object[] {oMateria.IdMateria, oMateria.NombreMateria.ToString(), detalle.Cuatrimestre.ToString(), detalle.AnioCursado.ToString()});
            }
        }

        private bool MateriaExists(string text)
        {
            foreach (DataGridViewRow item in dgvDetalles.Rows)
            {
                if (item.Cells["Materia"].Value.Equals(text))
                    return true;
            }
            return false;
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
