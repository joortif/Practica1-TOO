namespace Ejercicio2
{
    partial class fAux
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
            this.lbCuenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCuenta
            // 
            this.lbCuenta.AutoSize = true;
            this.lbCuenta.Location = new System.Drawing.Point(79, 117);
            this.lbCuenta.Name = "lbCuenta";
            this.lbCuenta.Size = new System.Drawing.Size(107, 13);
            this.lbCuenta.TabIndex = 0;
            this.lbCuenta.Text = "El número de clics es";
            // 
            // fAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 323);
            this.Controls.Add(this.lbCuenta);
            this.Name = "fAux";
            this.Text = "Contar clics";
            this.Load += new System.EventHandler(this.fAux_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCuenta;
    }
}