﻿namespace ProyectoFinal_ProgramacionCShearp
{
    partial class ctrlInscripcion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRegistroEstudiante = new System.Windows.Forms.Panel();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlRegistroEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(584, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 343);
            this.panel1.TabIndex = 46;
            // 
            // pnlRegistroEstudiante
            // 
            this.pnlRegistroEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.pnlRegistroEstudiante.Controls.Add(this.cbCursos);
            this.pnlRegistroEstudiante.Controls.Add(this.cbEstudiante);
            this.pnlRegistroEstudiante.Controls.Add(this.label1);
            this.pnlRegistroEstudiante.Controls.Add(this.btnRegistrar);
            this.pnlRegistroEstudiante.Controls.Add(this.label13);
            this.pnlRegistroEstudiante.Controls.Add(this.label12);
            this.pnlRegistroEstudiante.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlRegistroEstudiante.Location = new System.Drawing.Point(12, 31);
            this.pnlRegistroEstudiante.Name = "pnlRegistroEstudiante";
            this.pnlRegistroEstudiante.Size = new System.Drawing.Size(519, 343);
            this.pnlRegistroEstudiante.TabIndex = 45;
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(181, 122);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(199, 21);
            this.cbCursos.TabIndex = 47;
            // 
            // cbEstudiante
            // 
            this.cbEstudiante.FormattingEnabled = true;
            this.cbEstudiante.Location = new System.Drawing.Point(181, 58);
            this.cbEstudiante.Name = "cbEstudiante";
            this.cbEstudiante.Size = new System.Drawing.Size(199, 21);
            this.cbEstudiante.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Estudiante";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Blue;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(252, 202);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 42;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Javanese Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(228, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 41);
            this.label13.TabIndex = 40;
            this.label13.Text = "Inscripcion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Javanese Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(118, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 32);
            this.label12.TabIndex = 30;
            this.label12.Text = "Curso";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_ProgramacionCShearp.Properties.Resources.Untitled_design;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlRegistroEstudiante);
            this.Name = "ctrlInscripcion";
            this.Size = new System.Drawing.Size(707, 401);
            this.Load += new System.EventHandler(this.CtrlInscripcion_Load);
            this.panel1.ResumeLayout(false);
            this.pnlRegistroEstudiante.ResumeLayout(false);
            this.pnlRegistroEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRegistroEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
