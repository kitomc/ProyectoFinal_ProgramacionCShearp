namespace ProyectoFinal_ProgramacionCShearp
{
    partial class ctrlCalificar
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
            this.pnlRegistroEstudiante = new System.Windows.Forms.Panel();
            this.cbEstudiante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbNota = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRegistroEstudiante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegistroEstudiante
            // 
            this.pnlRegistroEstudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.pnlRegistroEstudiante.Controls.Add(this.cbCursos);
            this.pnlRegistroEstudiante.Controls.Add(this.label2);
            this.pnlRegistroEstudiante.Controls.Add(this.cbNota);
            this.pnlRegistroEstudiante.Controls.Add(this.cbEstudiante);
            this.pnlRegistroEstudiante.Controls.Add(this.label1);
            this.pnlRegistroEstudiante.Controls.Add(this.btnEnviar);
            this.pnlRegistroEstudiante.Controls.Add(this.label13);
            this.pnlRegistroEstudiante.Controls.Add(this.label12);
            this.pnlRegistroEstudiante.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlRegistroEstudiante.Location = new System.Drawing.Point(28, 30);
            this.pnlRegistroEstudiante.Name = "pnlRegistroEstudiante";
            this.pnlRegistroEstudiante.Size = new System.Drawing.Size(499, 338);
            this.pnlRegistroEstudiante.TabIndex = 47;
            this.pnlRegistroEstudiante.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlRegistroEstudiante_Paint);
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
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Blue;
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(238, 201);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 42;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Javanese Text", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(228, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 43);
            this.label13.TabIndex = 40;
            this.label13.Text = "Calificar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Javanese Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(175, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 32);
            this.label12.TabIndex = 30;
            this.label12.Text = "Nota";
            // 
            // cbNota
            // 
            this.cbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNota.Location = new System.Drawing.Point(233, 151);
            this.cbNota.MaxLength = 2;
            this.cbNota.Name = "cbNota";
            this.cbNota.Size = new System.Drawing.Size(80, 30);
            this.cbNota.TabIndex = 47;
            this.cbNota.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.cbNota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbNota_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_ProgramacionCShearp.Properties.Resources.sp_trufit160x600;
            this.pictureBox1.Location = new System.Drawing.Point(586, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(181, 102);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(199, 21);
            this.cbCursos.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Curso";
            // 
            // ctrlCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlRegistroEstudiante);
            this.Name = "ctrlCalificar";
            this.Size = new System.Drawing.Size(707, 401);
            this.Load += new System.EventHandler(this.CtrlCalificar_Load);
            this.pnlRegistroEstudiante.ResumeLayout(false);
            this.pnlRegistroEstudiante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlRegistroEstudiante;
        private System.Windows.Forms.ComboBox cbEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cbNota;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label label2;
    }
}
