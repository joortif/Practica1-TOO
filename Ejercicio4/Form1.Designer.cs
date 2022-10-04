namespace Ejercicio4
{
    partial class FormEjer4
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
            this.btCrearBt = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCrearBt
            // 
            this.btCrearBt.Location = new System.Drawing.Point(80, 69);
            this.btCrearBt.Name = "btCrearBt";
            this.btCrearBt.Size = new System.Drawing.Size(76, 80);
            this.btCrearBt.TabIndex = 0;
            this.btCrearBt.Text = "Crear botón";
            this.btCrearBt.UseVisualStyleBackColor = true;
            this.btCrearBt.Click += new System.EventHandler(this.btCrearBt_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(561, 276);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(98, 52);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // FormEjer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btCrearBt);
            this.Name = "FormEjer4";
            this.Text = "Crear botón";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCrearBt;
        private System.Windows.Forms.Button btSalir;
    }
}

