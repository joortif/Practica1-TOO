namespace Ejercicio2
{
    partial class FormEjer2
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
            this.btClicks = new System.Windows.Forms.Button();
            this.btContar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btClicks
            // 
            this.btClicks.Location = new System.Drawing.Point(72, 54);
            this.btClicks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClicks.Name = "btClicks";
            this.btClicks.Size = new System.Drawing.Size(125, 96);
            this.btClicks.TabIndex = 0;
            this.btClicks.Text = "Click";
            this.btClicks.UseVisualStyleBackColor = true;
            this.btClicks.Click += new System.EventHandler(this.btClicks_Click);
            // 
            // btContar
            // 
            this.btContar.Location = new System.Drawing.Point(588, 121);
            this.btContar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btContar.Name = "btContar";
            this.btContar.Size = new System.Drawing.Size(100, 28);
            this.btContar.TabIndex = 1;
            this.btContar.Text = "Contar";
            this.btContar.UseVisualStyleBackColor = true;
            this.btContar.Click += new System.EventHandler(this.btContar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(588, 348);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 28);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // FormEjer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btContar);
            this.Controls.Add(this.btClicks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEjer2";
            this.Text = "Contar clics";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btClicks;
        private System.Windows.Forms.Button btContar;
        private System.Windows.Forms.Button btSalir;
    }
}

