
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
            this.ver_carrera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit_carrera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_carrera = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Black", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(221, 310);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 37);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvCarreras
            // 
            this.dgvCarreras.AllowUserToDeleteRows = false;
            this.dgvCarreras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarreras.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvCarreras.ColumnHeadersHeight = 43;
            this.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nro_carrera,
            this.nom_carrera,
            this.ver_carrera,
            this.edit_carrera,
            this.delete_carrera});
            this.dgvCarreras.Location = new System.Drawing.Point(36, 77);
            this.dgvCarreras.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvCarreras.Name = "dgvCarreras";
            this.dgvCarreras.ReadOnly = true;
            this.dgvCarreras.RowHeadersWidth = 82;
            this.dgvCarreras.Size = new System.Drawing.Size(501, 214);
            this.dgvCarreras.TabIndex = 2;
            this.dgvCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCarreras_CellContentClick);
            // 
            // nro_carrera
            // 
            this.nro_carrera.HeaderText = "";
            this.nro_carrera.MinimumWidth = 10;
            this.nro_carrera.Name = "nro_carrera";
            this.nro_carrera.ReadOnly = true;
            this.nro_carrera.Visible = false;
            // 
            // nom_carrera
            // 
            this.nom_carrera.HeaderText = "Carrera";
            this.nom_carrera.MinimumWidth = 450;
            this.nom_carrera.Name = "nom_carrera";
            this.nom_carrera.ReadOnly = true;
            this.nom_carrera.Width = 450;
            // 
            // ver_carrera
            // 
            this.ver_carrera.HeaderText = "";
            this.ver_carrera.Name = "ver_carrera";
            this.ver_carrera.ReadOnly = true;
            this.ver_carrera.Text = "Ver";
            this.ver_carrera.ToolTipText = "Ver";
            this.ver_carrera.UseColumnTextForButtonValue = true;
            this.ver_carrera.Width = 130;
            // 
            // edit_carrera
            // 
            this.edit_carrera.HeaderText = "";
            this.edit_carrera.Name = "edit_carrera";
            this.edit_carrera.ReadOnly = true;
            this.edit_carrera.Text = "Editar";
            this.edit_carrera.UseColumnTextForButtonValue = true;
            this.edit_carrera.Width = 130;
            // 
            // delete_carrera
            // 
            this.delete_carrera.HeaderText = "";
            this.delete_carrera.Name = "delete_carrera";
            this.delete_carrera.ReadOnly = true;
            this.delete_carrera.Text = "Eliminar";
            this.delete_carrera.UseColumnTextForButtonValue = true;
            this.delete_carrera.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Planes de Estudio";
            // 
            // FrmConsultarPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCarreras);
            this.Controls.Add(this.btnCerrar);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FrmConsultarPlanes";
            this.Text = "ConsultarPlanes";
            this.Load += new System.EventHandler(this.FrmConsultarPlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nro_carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_carrera;
        private System.Windows.Forms.DataGridViewButtonColumn ver_carrera;
        private System.Windows.Forms.DataGridViewButtonColumn edit_carrera;
        private System.Windows.Forms.DataGridViewButtonColumn delete_carrera;
    }
}