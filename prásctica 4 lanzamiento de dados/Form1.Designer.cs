namespace prásctica_4_lanzamiento_de_dados
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
            this.txtResutado = new System.Windows.Forms.TextBox();
            this.btnLanzarRepeticiones = new System.Windows.Forms.Button();
            this.btnlanzarSuma = new System.Windows.Forms.Button();
            this.lblenunciado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResutado
            // 
            this.txtResutado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResutado.Location = new System.Drawing.Point(64, 111);
            this.txtResutado.Multiline = true;
            this.txtResutado.Name = "txtResutado";
            this.txtResutado.ReadOnly = true;
            this.txtResutado.Size = new System.Drawing.Size(293, 249);
            this.txtResutado.TabIndex = 0;
            // 
            // btnLanzarRepeticiones
            // 
            this.btnLanzarRepeticiones.Location = new System.Drawing.Point(27, 52);
            this.btnLanzarRepeticiones.Name = "btnLanzarRepeticiones";
            this.btnLanzarRepeticiones.Size = new System.Drawing.Size(155, 53);
            this.btnLanzarRepeticiones.TabIndex = 1;
            this.btnLanzarRepeticiones.Text = "Repeticiones de cada cara";
            this.btnLanzarRepeticiones.UseVisualStyleBackColor = true;
            this.btnLanzarRepeticiones.Click += new System.EventHandler(this.btnLanzarRepeticiones_Click);
            // 
            // btnlanzarSuma
            // 
            this.btnlanzarSuma.Location = new System.Drawing.Point(244, 52);
            this.btnlanzarSuma.Name = "btnlanzarSuma";
            this.btnlanzarSuma.Size = new System.Drawing.Size(155, 53);
            this.btnlanzarSuma.TabIndex = 2;
            this.btnlanzarSuma.Text = "Frecuencia de suma";
            this.btnlanzarSuma.UseVisualStyleBackColor = true;
            this.btnlanzarSuma.Click += new System.EventHandler(this.btnlanzarSuma_Click);
            // 
            // lblenunciado
            // 
            this.lblenunciado.AutoSize = true;
            this.lblenunciado.Location = new System.Drawing.Point(131, 9);
            this.lblenunciado.Name = "lblenunciado";
            this.lblenunciado.Size = new System.Drawing.Size(165, 40);
            this.lblenunciado.TabIndex = 3;
            this.lblenunciado.Text = "LANZAR DADO \r\nPARA SABER LA(S)";
            this.lblenunciado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 372);
            this.Controls.Add(this.lblenunciado);
            this.Controls.Add(this.btnlanzarSuma);
            this.Controls.Add(this.btnLanzarRepeticiones);
            this.Controls.Add(this.txtResutado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResutado;
        private System.Windows.Forms.Button btnLanzarRepeticiones;
        private System.Windows.Forms.Button btnlanzarSuma;
        private System.Windows.Forms.Label lblenunciado;
    }
}

