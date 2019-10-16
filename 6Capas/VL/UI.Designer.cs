namespace VL
{
    partial class UI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.button1Alta = new System.Windows.Forms.Button();
            this.textBoxErrores = new System.Windows.Forms.TextBox();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonMODIFICACION = new System.Windows.Forms.Button();
            this.button3CONSULTA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(478, 258);
            this.dataGridView1.TabIndex = 9;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(69, 100);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(240, 22);
            this.textBoxApellido.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(69, 66);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(240, 22);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(69, 32);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(240, 22);
            this.textBoxDni.TabIndex = 6;
            // 
            // button1Alta
            // 
            this.button1Alta.Location = new System.Drawing.Point(343, 32);
            this.button1Alta.Margin = new System.Windows.Forms.Padding(6);
            this.button1Alta.Name = "button1Alta";
            this.button1Alta.Size = new System.Drawing.Size(126, 30);
            this.button1Alta.TabIndex = 5;
            this.button1Alta.Text = "ALTA";
            this.button1Alta.UseVisualStyleBackColor = true;
            this.button1Alta.Click += new System.EventHandler(this.button1Alta_Click);
            // 
            // textBoxErrores
            // 
            this.textBoxErrores.Location = new System.Drawing.Point(15, 405);
            this.textBoxErrores.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxErrores.Multiline = true;
            this.textBoxErrores.Name = "textBoxErrores";
            this.textBoxErrores.Size = new System.Drawing.Size(478, 49);
            this.textBoxErrores.TabIndex = 10;
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(343, 66);
            this.buttonBaja.Margin = new System.Windows.Forms.Padding(6);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(126, 30);
            this.buttonBaja.TabIndex = 11;
            this.buttonBaja.Text = "BAJA";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonMODIFICACION
            // 
            this.buttonMODIFICACION.Location = new System.Drawing.Point(481, 32);
            this.buttonMODIFICACION.Margin = new System.Windows.Forms.Padding(6);
            this.buttonMODIFICACION.Name = "buttonMODIFICACION";
            this.buttonMODIFICACION.Size = new System.Drawing.Size(126, 30);
            this.buttonMODIFICACION.TabIndex = 12;
            this.buttonMODIFICACION.Text = "MODIFICACION";
            this.buttonMODIFICACION.UseVisualStyleBackColor = true;
            this.buttonMODIFICACION.Click += new System.EventHandler(this.buttonMODIFICACION_Click);
            // 
            // button3CONSULTA
            // 
            this.button3CONSULTA.Location = new System.Drawing.Point(481, 66);
            this.button3CONSULTA.Margin = new System.Windows.Forms.Padding(6);
            this.button3CONSULTA.Name = "button3CONSULTA";
            this.button3CONSULTA.Size = new System.Drawing.Size(126, 30);
            this.button3CONSULTA.TabIndex = 13;
            this.button3CONSULTA.Text = "CONSULTA ";
            this.button3CONSULTA.UseVisualStyleBackColor = true;
            this.button3CONSULTA.Click += new System.EventHandler(this.button3CONSULTA_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 469);
            this.Controls.Add(this.button3CONSULTA);
            this.Controls.Add(this.buttonMODIFICACION);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.textBoxErrores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.button1Alta);
            this.Name = "UI";
            this.Text = "UI";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Button button1Alta;
        private System.Windows.Forms.TextBox textBoxErrores;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonMODIFICACION;
        private System.Windows.Forms.Button button3CONSULTA;
    }
}