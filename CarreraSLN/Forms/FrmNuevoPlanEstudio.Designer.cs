﻿
namespace CarreraSLN.Forms
{
    partial class FrmNuevoPlanEstudio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.txtAnioCursado = new System.Windows.Forms.TextBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_cursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGrabarPlan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCarreraName = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblnro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cuatrimestre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año Cursado";
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(265, 213);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(860, 39);
            this.txtCuatrimestre.TabIndex = 4;
            // 
            // txtAnioCursado
            // 
            this.txtAnioCursado.Location = new System.Drawing.Point(265, 287);
            this.txtAnioCursado.Name = "txtAnioCursado";
            this.txtAnioCursado.Size = new System.Drawing.Size(239, 39);
            this.txtAnioCursado.TabIndex = 5;
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(265, 136);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(860, 40);
            this.cboMaterias.TabIndex = 7;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_detalle,
            this.nombre_materia,
            this.cuatrimestre,
            this.anio_cursado,
            this.Eliminar});
            this.dgvDetalles.Location = new System.Drawing.Point(76, 404);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.RowHeadersWidth = 82;
            this.dgvDetalles.RowTemplate.Height = 41;
            this.dgvDetalles.Size = new System.Drawing.Size(1068, 360);
            this.dgvDetalles.TabIndex = 8;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick_1);
            // 
            // id_detalle
            // 
            this.id_detalle.HeaderText = "Column1";
            this.id_detalle.MinimumWidth = 10;
            this.id_detalle.Name = "id_detalle";
            this.id_detalle.Visible = false;
            this.id_detalle.Width = 200;
            // 
            // nombre_materia
            // 
            this.nombre_materia.HeaderText = "Materia";
            this.nombre_materia.MinimumWidth = 10;
            this.nombre_materia.Name = "nombre_materia";
            this.nombre_materia.Width = 200;
            // 
            // cuatrimestre
            // 
            this.cuatrimestre.HeaderText = "Cuatrimestre";
            this.cuatrimestre.MinimumWidth = 10;
            this.cuatrimestre.Name = "cuatrimestre";
            this.cuatrimestre.Width = 200;
            // 
            // anio_cursado
            // 
            this.anio_cursado.HeaderText = "Año Cursado";
            this.anio_cursado.MinimumWidth = 10;
            this.anio_cursado.Name = "anio_cursado";
            this.anio_cursado.Width = 200;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Acciones";
            this.Eliminar.MinimumWidth = 10;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Width = 200;
            // 
            // btnGrabarPlan
            // 
            this.btnGrabarPlan.Location = new System.Drawing.Point(317, 791);
            this.btnGrabarPlan.Name = "btnGrabarPlan";
            this.btnGrabarPlan.Size = new System.Drawing.Size(237, 71);
            this.btnGrabarPlan.TabIndex = 9;
            this.btnGrabarPlan.Text = "Aceptar";
            this.btnGrabarPlan.UseVisualStyleBackColor = true;
            this.btnGrabarPlan.Click += new System.EventHandler(this.btnGrabarPlan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 791);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtCarreraName
            // 
            this.txtCarreraName.Location = new System.Drawing.Point(265, 58);
            this.txtCarreraName.Name = "txtCarreraName";
            this.txtCarreraName.Size = new System.Drawing.Size(859, 39);
            this.txtCarreraName.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(822, 287);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(280, 57);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblnro
            // 
            this.lblnro.AutoSize = true;
            this.lblnro.Location = new System.Drawing.Point(583, 322);
            this.lblnro.Name = "lblnro";
            this.lblnro.Size = new System.Drawing.Size(0, 32);
            this.lblnro.TabIndex = 13;
            // 
            // FrmNuevoPlanEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 874);
            this.Controls.Add(this.lblnro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCarreraName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrabarPlan);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.txtAnioCursado);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevoPlanEstudio";
            this.Text = "FrmNuevoPlanEstudio";
            this.Load += new System.EventHandler(this.FrmNuevoPlanEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.TextBox txtAnioCursado;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnGrabarPlan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCarreraName;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_cursado;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label lblnro;
    }
}