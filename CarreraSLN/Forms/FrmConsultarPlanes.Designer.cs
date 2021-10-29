
namespace CarreraSLN.Forms
{
    partial class FrmConsultarPlanes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvCarreras = new System.Windows.Forms.DataGridView();
            this.nro_carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(416, 563);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(278, 79);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_carrera,
            this.nom_carrera});
            this.dgvCarreras.Location = new System.Drawing.Point(46, 46);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.RowHeadersWidth = 82;
            this.dgvCarreras.RowTemplate.Height = 41;
            this.dgvCarreras.Size = new System.Drawing.Size(961, 456);
            this.dgvCarreras.TabIndex = 2;
            // 
            // nro_carrera
            // 
            this.nro_carrera.HeaderText = "";
            this.nro_carrera.MinimumWidth = 10;
            this.nro_carrera.Name = "nro_carrera";
            this.nro_carrera.Visible = false;
            this.nro_carrera.Width = 600;
            // 
            // nom_carrera
            // 
            this.nom_carrera.HeaderText = "Carrera";
            this.nom_carrera.MinimumWidth = 10;
            this.nom_carrera.Name = "nom_carrera";
            this.nom_carrera.Width = 200;
            // 
            // FrmConsultarPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 654);
            this.Controls.Add(this.dgvCarreras);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FrmConsultarPlanes";
            this.Text = "ConsultarPlanes";
            this.Load += new System.EventHandler(this.FrmConsultarPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarreras;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_carrera;
        private System.Windows.Forms.DataGridViewButtonColumn ver_plan;
        private System.Windows.Forms.DataGridViewButtonColumn editar_plan;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar_plan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_carrera;
    }
}