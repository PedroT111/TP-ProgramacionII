
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_cursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 45);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(860, 39);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 287);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(860, 39);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(265, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(860, 40);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(265, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(860, 40);
            this.comboBox2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_detalle,
            this.nombre_materia,
            this.cuatrimestre,
            this.anio_cursado,
            this.actions});
            this.dataGridView1.Location = new System.Drawing.Point(57, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 360);
            this.dataGridView1.TabIndex = 8;
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
            // actions
            // 
            this.actions.HeaderText = "Acciones";
            this.actions.MinimumWidth = 10;
            this.actions.Name = "actions";
            this.actions.Width = 200;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 791);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(616, 791);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 71);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoPlanEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 874);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNuevoPlanEstudio";
            this.Text = "FrmNuevoPlanEstudio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_cursado;
        private System.Windows.Forms.DataGridViewButtonColumn actions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}