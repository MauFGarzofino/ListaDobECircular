namespace PrácticaLista1
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.cHoras = new System.Windows.Forms.TextBox();
            this.prueba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siguiente = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.eliminarUltimo = new System.Windows.Forms.Button();
            this.eliminarPrimero = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.eliminarL = new System.Windows.Forms.Button();
            this.pElemento = new System.Windows.Forms.Button();
            this.uElemento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertar
            // 
            this.insertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertar.ForeColor = System.Drawing.Color.Black;
            this.insertar.Location = new System.Drawing.Point(374, 76);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(129, 33);
            this.insertar.TabIndex = 0;
            this.insertar.Text = "INSERTAR";
            this.insertar.UseVisualStyleBackColor = false;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombre.Location = new System.Drawing.Point(198, 63);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(154, 20);
            this.nombre.TabIndex = 1;
            this.nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cHoras
            // 
            this.cHoras.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cHoras.Location = new System.Drawing.Point(198, 96);
            this.cHoras.Name = "cHoras";
            this.cHoras.Size = new System.Drawing.Size(154, 20);
            this.cHoras.TabIndex = 2;
            this.cHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prueba
            // 
            this.prueba.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.prueba.Location = new System.Drawing.Point(509, 76);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(167, 33);
            this.prueba.TabIndex = 3;
            this.prueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(103, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(105, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CHoras";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // siguiente
            // 
            this.siguiente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.siguiente.Location = new System.Drawing.Point(374, 160);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(113, 40);
            this.siguiente.TabIndex = 6;
            this.siguiente.Text = "siguiente";
            this.siguiente.UseVisualStyleBackColor = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // anterior
            // 
            this.anterior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anterior.Location = new System.Drawing.Point(251, 160);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(113, 40);
            this.anterior.TabIndex = 7;
            this.anterior.Text = "anterior";
            this.anterior.UseVisualStyleBackColor = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // eliminarUltimo
            // 
            this.eliminarUltimo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarUltimo.Location = new System.Drawing.Point(374, 220);
            this.eliminarUltimo.Name = "eliminarUltimo";
            this.eliminarUltimo.Size = new System.Drawing.Size(133, 40);
            this.eliminarUltimo.TabIndex = 8;
            this.eliminarUltimo.Text = "eliminarUltimo";
            this.eliminarUltimo.UseVisualStyleBackColor = false;
            this.eliminarUltimo.Click += new System.EventHandler(this.eliminarUltimo_Click);
            // 
            // eliminarPrimero
            // 
            this.eliminarPrimero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarPrimero.Location = new System.Drawing.Point(231, 220);
            this.eliminarPrimero.Name = "eliminarPrimero";
            this.eliminarPrimero.Size = new System.Drawing.Size(133, 40);
            this.eliminarPrimero.TabIndex = 9;
            this.eliminarPrimero.Text = "eliminarPrimero";
            this.eliminarPrimero.UseVisualStyleBackColor = false;
            this.eliminarPrimero.Click += new System.EventHandler(this.eliminarPrimero_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminar.Location = new System.Drawing.Point(306, 270);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(113, 40);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // eliminarL
            // 
            this.eliminarL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarL.Location = new System.Drawing.Point(306, 320);
            this.eliminarL.Name = "eliminarL";
            this.eliminarL.Size = new System.Drawing.Size(113, 40);
            this.eliminarL.TabIndex = 11;
            this.eliminarL.Text = "eliminarL";
            this.eliminarL.UseVisualStyleBackColor = false;
            this.eliminarL.Click += new System.EventHandler(this.eliminarL_Click);
            // 
            // pElemento
            // 
            this.pElemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pElemento.Location = new System.Drawing.Point(512, 160);
            this.pElemento.Name = "pElemento";
            this.pElemento.Size = new System.Drawing.Size(133, 35);
            this.pElemento.TabIndex = 12;
            this.pElemento.Text = "pElemento";
            this.pElemento.UseVisualStyleBackColor = false;
            this.pElemento.Click += new System.EventHandler(this.pElemento_Click);
            // 
            // uElemento
            // 
            this.uElemento.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uElemento.Location = new System.Drawing.Point(99, 163);
            this.uElemento.Name = "uElemento";
            this.uElemento.Size = new System.Drawing.Size(133, 35);
            this.uElemento.TabIndex = 13;
            this.uElemento.Text = "uElemento";
            this.uElemento.UseVisualStyleBackColor = false;
            this.uElemento.Click += new System.EventHandler(this.uElemento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uElemento);
            this.Controls.Add(this.pElemento);
            this.Controls.Add(this.eliminarL);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.eliminarPrimero);
            this.Controls.Add(this.eliminarUltimo);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.cHoras);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.insertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox cHoras;
        private System.Windows.Forms.Label prueba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button eliminarUltimo;
        private System.Windows.Forms.Button eliminarPrimero;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button eliminarL;
        private System.Windows.Forms.Button pElemento;
        private System.Windows.Forms.Button uElemento;
    }
}

