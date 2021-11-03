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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaterias frmMateria = new FrmMaterias();
            frmMateria.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoPlanEstudio frmPlan = new FrmNuevoPlanEstudio(Accion.Create, -1);
            frmPlan.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarPlanes frmConsulta = new FrmConsultarPlanes();
            frmConsulta.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void informacionDeDesarrolloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformacion frmInfo = new FrmInformacion();
            frmInfo.ShowDialog();
        }
    }
}
