namespace VISTA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxErrores = new System.Windows.Forms.TextBox();
            this.txValor = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txEgreso = new System.Windows.Forms.TextBox();
            this.txIngreso = new System.Windows.Forms.TextBox();
            this.txAnio = new System.Windows.Forms.TextBox();
            this.txpatente = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txFiltro = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 535);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 148);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBoxErrores
            // 
            this.textBoxErrores.Location = new System.Drawing.Point(649, 12);
            this.textBoxErrores.Multiline = true;
            this.textBoxErrores.Name = "textBoxErrores";
            this.textBoxErrores.Size = new System.Drawing.Size(292, 40);
            this.textBoxErrores.TabIndex = 1;
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(27, 85);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(147, 22);
            this.txValor.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "MOD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "BAJA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "ALTA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txEgreso
            // 
            this.txEgreso.Location = new System.Drawing.Point(27, 141);
            this.txEgreso.Name = "txEgreso";
            this.txEgreso.Size = new System.Drawing.Size(147, 22);
            this.txEgreso.TabIndex = 18;
            // 
            // txIngreso
            // 
            this.txIngreso.Location = new System.Drawing.Point(27, 113);
            this.txIngreso.Name = "txIngreso";
            this.txIngreso.Size = new System.Drawing.Size(147, 22);
            this.txIngreso.TabIndex = 17;
            // 
            // txAnio
            // 
            this.txAnio.Location = new System.Drawing.Point(27, 58);
            this.txAnio.Name = "txAnio";
            this.txAnio.Size = new System.Drawing.Size(147, 22);
            this.txAnio.TabIndex = 16;
            // 
            // txpatente
            // 
            this.txpatente.BackColor = System.Drawing.Color.White;
            this.txpatente.Location = new System.Drawing.Point(27, 30);
            this.txpatente.Name = "txpatente";
            this.txpatente.Size = new System.Drawing.Size(147, 22);
            this.txpatente.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "ConsultaValorResidual";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txFiltro
            // 
            this.txFiltro.Location = new System.Drawing.Point(12, 507);
            this.txFiltro.Name = "txFiltro";
            this.txFiltro.Size = new System.Drawing.Size(147, 22);
            this.txFiltro.TabIndex = 24;
            this.txFiltro.TextChanged += new System.EventHandler(this.txFiltro_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(180, 85);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(786, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "GDI";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(180, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(786, 387);
            this.dataGridView2.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(972, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "MOD";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 710);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txFiltro);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txEgreso);
            this.Controls.Add(this.txIngreso);
            this.Controls.Add(this.txAnio);
            this.Controls.Add(this.txpatente);
            this.Controls.Add(this.textBoxErrores);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxErrores;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txEgreso;
        private System.Windows.Forms.TextBox txIngreso;
        private System.Windows.Forms.TextBox txAnio;
        private System.Windows.Forms.TextBox txpatente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txFiltro;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button6;
    }
}

