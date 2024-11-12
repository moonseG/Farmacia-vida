namespace Farmacia__vida
{
    partial class FormCobro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MontoPagar = new System.Windows.Forms.Label();
            this.MontoRecibido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textRecibido = new System.Windows.Forms.TextBox();
            this.LabelMostrar = new System.Windows.Forms.Label();
            this.BContinuar = new System.Windows.Forms.Button();
            this.labelCambio = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.BFinalizar = new System.Windows.Forms.Button();
            this.textPagar = new System.Windows.Forms.TextBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 43);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Servicio de Cajero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MontoPagar
            // 
            this.MontoPagar.AutoSize = true;
            this.MontoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.MontoPagar.Location = new System.Drawing.Point(396, 217);
            this.MontoPagar.Name = "MontoPagar";
            this.MontoPagar.Size = new System.Drawing.Size(118, 20);
            this.MontoPagar.TabIndex = 10;
            this.MontoPagar.Text = "Monto a Pagar";
            // 
            // MontoRecibido
            // 
            this.MontoRecibido.AutoSize = true;
            this.MontoRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.MontoRecibido.Location = new System.Drawing.Point(396, 263);
            this.MontoRecibido.Name = "MontoRecibido";
            this.MontoRecibido.Size = new System.Drawing.Size(125, 20);
            this.MontoRecibido.TabIndex = 12;
            this.MontoRecibido.Text = "Monto Recibido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(396, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cambio";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textRecibido
            // 
            this.textRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textRecibido.Location = new System.Drawing.Point(545, 263);
            this.textRecibido.Name = "textRecibido";
            this.textRecibido.Size = new System.Drawing.Size(100, 27);
            this.textRecibido.TabIndex = 15;
            this.textRecibido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LabelMostrar
            // 
            this.LabelMostrar.AutoSize = true;
            this.LabelMostrar.Location = new System.Drawing.Point(27, 101);
            this.LabelMostrar.Name = "LabelMostrar";
            this.LabelMostrar.Size = new System.Drawing.Size(44, 16);
            this.LabelMostrar.TabIndex = 16;
            this.LabelMostrar.Text = "label3";
            this.LabelMostrar.Click += new System.EventHandler(this.LabelMostrar_Click);
            // 
            // BContinuar
            // 
            this.BContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BContinuar.Location = new System.Drawing.Point(664, 256);
            this.BContinuar.Name = "BContinuar";
            this.BContinuar.Size = new System.Drawing.Size(105, 34);
            this.BContinuar.TabIndex = 20;
            this.BContinuar.Text = "Continuar";
            this.BContinuar.UseVisualStyleBackColor = true;
            this.BContinuar.Click += new System.EventHandler(this.BContinuar_Click);
            // 
            // labelCambio
            // 
            this.labelCambio.AutoSize = true;
            this.labelCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.labelCambio.Location = new System.Drawing.Point(558, 323);
            this.labelCambio.Name = "labelCambio";
            this.labelCambio.Size = new System.Drawing.Size(31, 20);
            this.labelCambio.TabIndex = 21;
            this.labelCambio.Text = "0.0";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::Farmacia__vida.Properties.Resources.hogar;
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(59, 376);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(145, 56);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // BFinalizar
            // 
            this.BFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.BFinalizar.Image = global::Farmacia__vida.Properties.Resources.terminado;
            this.BFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BFinalizar.Location = new System.Drawing.Point(647, 376);
            this.BFinalizar.Name = "BFinalizar";
            this.BFinalizar.Size = new System.Drawing.Size(122, 56);
            this.BFinalizar.TabIndex = 19;
            this.BFinalizar.Text = "Finalizar";
            this.BFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFinalizar.UseVisualStyleBackColor = true;
            this.BFinalizar.Click += new System.EventHandler(this.BFinalizar_Click);
            // 
            // textPagar
            // 
            this.textPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.textPagar.Location = new System.Drawing.Point(545, 217);
            this.textPagar.Name = "textPagar";
            this.textPagar.Size = new System.Drawing.Size(100, 27);
            this.textPagar.TabIndex = 26;
            this.textPagar.TextChanged += new System.EventHandler(this.textPagar_TextChanged);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Precio});
            this.dataGridViewProductos.Location = new System.Drawing.Point(30, 136);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(310, 207);
            this.dataGridViewProductos.TabIndex = 27;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // FormCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 460);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.textPagar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.labelCambio);
            this.Controls.Add(this.BContinuar);
            this.Controls.Add(this.BFinalizar);
            this.Controls.Add(this.LabelMostrar);
            this.Controls.Add(this.textRecibido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MontoRecibido);
            this.Controls.Add(this.MontoPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormCobro";
            this.Text = "FormCobro";
            this.Load += new System.EventHandler(this.FormCobro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MontoPagar;
        private System.Windows.Forms.Label MontoRecibido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRecibido;
        private System.Windows.Forms.Label LabelMostrar;
        private System.Windows.Forms.Button BFinalizar;
        private System.Windows.Forms.Button BContinuar;
        private System.Windows.Forms.Label labelCambio;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox textPagar;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}