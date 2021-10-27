
namespace CarreraSLN.Forms
{
    partial class FrmMaterias
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
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnCrearMateria = new System.Windows.Forms.Button();
            this.btnEditarMateria = new System.Windows.Forms.Button();
            this.lstMaterias = new System.Windows.Forms.ListView();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(97, 351);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(553, 39);
            this.txtMateria.TabIndex = 1;
            // 
            // btnCrearMateria
            // 
            this.btnCrearMateria.Location = new System.Drawing.Point(63, 771);
            this.btnCrearMateria.Name = "btnCrearMateria";
            this.btnCrearMateria.Size = new System.Drawing.Size(258, 83);
            this.btnCrearMateria.TabIndex = 2;
            this.btnCrearMateria.Text = "Crear";
            this.btnCrearMateria.UseVisualStyleBackColor = true;
            this.btnCrearMateria.Click += new System.EventHandler(this.btnCrearMateria_Click);
            // 
            // btnEditarMateria
            // 
            this.btnEditarMateria.Location = new System.Drawing.Point(388, 773);
            this.btnEditarMateria.Name = "btnEditarMateria";
            this.btnEditarMateria.Size = new System.Drawing.Size(262, 81);
            this.btnEditarMateria.TabIndex = 3;
            this.btnEditarMateria.Text = "Editar";
            this.btnEditarMateria.UseVisualStyleBackColor = true;
            // 
            // lstMaterias
            // 
            this.lstMaterias.HideSelection = false;
            this.lstMaterias.Location = new System.Drawing.Point(788, 22);
            this.lstMaterias.Name = "lstMaterias";
            this.lstMaterias.Size = new System.Drawing.Size(578, 704);
            this.lstMaterias.TabIndex = 1;
            this.lstMaterias.UseCompatibleStateImageBehavior = false;
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(734, 773);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(261, 81);
            this.btnEliminarMateria.TabIndex = 5;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1064, 772);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(261, 81);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 895);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.lstMaterias);
            this.Controls.Add(this.btnEditarMateria);
            this.Controls.Add(this.btnCrearMateria);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label1);
            this.Name = "FrmMaterias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.FrmMaterias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnCrearMateria;
        private System.Windows.Forms.Button btnEditarMateria;
        private System.Windows.Forms.ListView lstMaterias;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnCancelar;
    }
}