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
    public partial class FrmRegistro : Form
    {
        private User oUser;
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            oUser = new User();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == txtConfirmar.Text)
            {
                oUser.usuario = txtUsuario.Text;
                oUser.pass = txtContrasenia.Text;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string data = JsonConvert.SerializeObject(oUser);
            bool registro = await RegistrarAsync(data);
            if (registro == true)
            {
                MessageBox.Show("El registro se ha concretado con éxito.", "Registro", MessageBoxButtons.OK);
                FormLogin.ActiveForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Es posible que el usuario ya esté registrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private async Task<bool> RegistrarAsync(string data)
        {
            string url = "https://localhost:5001/api/Carrera/registro";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }
    }
}
