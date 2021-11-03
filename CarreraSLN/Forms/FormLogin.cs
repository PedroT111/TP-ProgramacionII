using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarreraSLN.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "grupo6" && txtContraseña.Text == "123456")
            {
                FrmMain frm = new FrmMain();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
