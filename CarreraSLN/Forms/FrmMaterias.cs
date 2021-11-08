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
    public partial class FrmMaterias : Form
    {
        private Accion modo;
        Materia oMateria;
        public FrmMaterias()
        {
            InitializeComponent();
        }

        private async void FrmMaterias_Load(object sender, EventArgs e)
        {
            oMateria = new Materia();
            modo = Accion.Create;
            await cargarMateriasAsync();
        }

        private void LimpiarLista()
        {
            dgvMaterias.Rows.Clear();
        }

        private async Task cargarMateriasAsync()
        {
            string url = "https://localhost:5001/api/Carrera/materias";
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(url);
            var content = await result.Content.ReadAsStringAsync();
            List<Materia> lst = JsonConvert.DeserializeObject<List<Materia>>(content);

            foreach (Materia item in lst)
            {
                dgvMaterias.Rows.Add(new object[] { item.IdMateria, item.NombreMateria.ToString()});
            };

        }

        private async Task<bool> crearNuevaMateriaAsync(string data)
        {
            string url = "https://localhost:5001/api/Carrera/materias";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }

        private async void btnCrearMateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMateria.Text))
            {
                MessageBox.Show("Ingrese un nombre");
                return;
            }
            /*if (existeMateria(txtMateria.Text.ToString()))
            {
                MessageBox.Show("La materia ya esta registrada");
                return;
            }*/
            if (modo.Equals(Accion.Create))
            {
                Materia oMateria = new Materia();
                oMateria.NombreMateria = txtMateria.Text;
                string data = JsonConvert.SerializeObject(oMateria);

                bool success = await crearNuevaMateriaAsync(data);
                if (success)
                {
                    MessageBox.Show("Materia registrada con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al registrar Materia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarLista();
                LimpiarCampos();
                await cargarMateriasAsync();
            }
            if (modo.Equals(Accion.Update))
            {
                oMateria.NombreMateria = txtMateria.Text;
                oMateria.IdMateria = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["id_materia"].Value);
                await EditarMateriaAsync(oMateria.IdMateria);
                dgvMaterias.Rows.Clear();
                await cargarMateriasAsync();
            }
                                   
        }

        public void LimpiarCampos()
        {
            txtMateria.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /*private bool existeMateria(string text)
        {
            foreach (DataGridViewRow item in dgvMaterias.Rows)
            {
                if (item.Cells["nombre_materia"].Value.Equals(text))
                    return true;
            }
            return false;
        }
        */
        private async Task EliminarMateriaAsync(int id)
        {
            string url = "https://localhost:5001/api/Carrera/materias/" + id.ToString();
            HttpClient client = new HttpClient();
            var result = await client.DeleteAsync(url);
            var responseContent = await result.Content.ReadAsStringAsync();

        }

        private async void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea borrar la materia? Se borrará de los Planes de Estudio", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) 
            {
                int id = Convert.ToInt32(dgvMaterias.CurrentRow.Cells["id_materia"].Value.ToString());
                await EliminarMateriaAsync(id);
                dgvMaterias.Rows.Remove(dgvMaterias.CurrentRow);
            }
             
        }

        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            modo = Accion.Update;
            btnEliminarMateria.Enabled = false;
        }

        public async Task<bool> EditarMateriaAsync(int id)
        {
            string url = "https://localhost:5001/api/Carrera/materias/" + id.ToString();
            using (HttpClient client = new HttpClient())
            {
                string data = JsonConvert.SerializeObject(oMateria);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var resultado = await client.PostAsync(url, content);
                string response = await resultado.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }   
    }
}
