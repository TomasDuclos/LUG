namespace VISTA
{
    partial class ABM
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txEgreso = new System.Windows.Forms.TextBox();
            this.txIngreso = new System.Windows.Forms.TextBox();
            this.txAnio = new System.Windows.Forms.TextBox();
            this.txpatente = new System.Windows.Forms.TextBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(114, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "MOD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "BAJA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "ALTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txEgreso
            // 
            this.txEgreso.Location = new System.Drawing.Point(114, 127);
            this.txEgreso.Name = "txEgreso";
            this.txEgreso.Size = new System.Drawing.Size(147, 22);
            this.txEgreso.TabIndex = 10;
            // 
            // txIngreso
            // 
            this.txIngreso.Location = new System.Drawing.Point(114, 99);
            this.txIngreso.Name = "txIngreso";
            this.txIngreso.Size = new System.Drawing.Size(147, 22);
            this.txIngreso.TabIndex = 9;
            // 
            // txAnio
            // 
            this.txAnio.Location = new System.Drawing.Point(114, 44);
            this.txAnio.Name = "txAnio";
            this.txAnio.Size = new System.Drawing.Size(147, 22);
            this.txAnio.TabIndex = 8;
            // 
            // txpatente
            // 
            this.txpatente.BackColor = System.Drawing.Color.White;
            this.txpatente.Location = new System.Drawing.Point(114, 16);
            this.txpatente.Name = "txpatente";
            this.txpatente.Size = new System.Drawing.Size(147, 22);
            this.txpatente.TabIndex = 7;
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(114, 71);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(147, 22);
            this.txValor.TabIndex = 14;
            // 
            // ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txEgreso);
            this.Controls.Add(this.txIngreso);
            this.Controls.Add(this.txAnio);
            this.Controls.Add(this.txpatente);
            this.Name = "ABM";
            this.Size = new System.Drawing.Size(278, 251);
            this.Load += new System.EventHandler(this.ABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txEgreso;
        private System.Windows.Forms.TextBox txIngreso;
        private System.Windows.Forms.TextBox txAnio;
        private System.Windows.Forms.TextBox txpatente;
        private System.Windows.Forms.TextBox txValor;
    }
}
