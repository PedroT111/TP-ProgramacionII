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
    public partial class FormLogin : Form
    {
        private User oUser;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            oUser = new User();
        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            oUser.usuario = txtUsuario.Text;
            oUser.pass = txtContraseña.Text;
            string data = JsonConvert.SerializeObject(oUser);
            bool login = await IniciarSesionAsync(data);
            if(login == true)
            {
                FrmMain frm = new FrmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private async Task<bool> IniciarSesionAsync(string data)
        {
            string url = "https://localhost:5001/api/Carrera/login";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro registroForm = new FrmRegistro();
            this.Hide();
            registroForm.Show();
        }
    }
}
