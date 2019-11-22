namespace Vista
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFP = new System.Windows.Forms.TextBox();
            this.textBoxprecio = new System.Windows.Forms.TextBox();
            this.textBoxDIR = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTBOXFV = new System.Windows.Forms.TextBox();
            this.buttonGraficar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 513);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 190);
            this.dataGridView1.TabIndex = 28;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(258, 25);
            this.button6.TabIndex = 59;
            this.button6.Text = "BAJA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 182);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(258, 25);
            this.button5.TabIndex = 58;
            this.button5.Text = "MODIFICACION ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 23);
            this.button4.TabIndex = 57;
            this.button4.Text = "ALTA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "FP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "PRECIO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "DIR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "ID";
            // 
            // textBoxFP
            // 
            this.textBoxFP.Location = new System.Drawing.Point(111, 127);
            this.textBoxFP.Name = "textBoxFP";
            this.textBoxFP.Size = new System.Drawing.Size(159, 22);
            this.textBoxFP.TabIndex = 52;
            // 
            // textBoxprecio
            // 
            this.textBoxprecio.Location = new System.Drawing.Point(111, 99);
            this.textBoxprecio.Name = "textBoxprecio";
            this.textBoxprecio.Size = new System.Drawing.Size(159, 22);
            this.textBoxprecio.TabIndex = 51;
            // 
            // textBoxDIR
            // 
            this.textBoxDIR.Location = new System.Drawing.Point(111, 70);
            this.textBoxDIR.Name = "textBoxDIR";
            this.textBoxDIR.Size = new System.Drawing.Size(159, 22);
            this.textBoxDIR.TabIndex = 50;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(111, 41);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(159, 22);
            this.textBoxId.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "FV";
            // 
            // TXTBOXFV
            // 
            this.TXTBOXFV.Location = new System.Drawing.Point(111, 155);
            this.TXTBOXFV.Name = "TXTBOXFV";
            this.TXTBOXFV.Size = new System.Drawing.Size(159, 22);
            this.TXTBOXFV.TabIndex = 60;
            // 
            // buttonGraficar
            // 
            this.buttonGraficar.Location = new System.Drawing.Point(12, 246);
            this.buttonGraficar.Name = "buttonGraficar";
            this.buttonGraficar.Size = new System.Drawing.Size(258, 25);
            this.buttonGraficar.TabIndex = 62;
            this.buttonGraficar.Text = "GDI";
            this.buttonGraficar.UseVisualStyleBackColor = true;
            this.buttonGraficar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 307);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(730, 190);
            this.dataGridView2.TabIndex = 63;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(583, 279);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(159, 22);
            this.textBoxFiltro.TabIndex = 64;
            this.textBoxFiltro.TextChanged += new System.EventHandler(this.textBoxFiltro_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(765, 513);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(730, 190);
            this.dataGridView3.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 715);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonGraficar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBOXFV);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFP);
            this.Controls.Add(this.textBoxprecio);
            this.Controls.Add(this.textBoxDIR);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFP;
        private System.Windows.Forms.TextBox textBoxprecio;
        private System.Windows.Forms.TextBox textBoxDIR;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTBOXFV;
        private System.Windows.Forms.Button buttonGraficar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBoxFiltro;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

