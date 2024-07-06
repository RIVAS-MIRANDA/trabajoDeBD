namespace trabajoDeBD
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardar = new FontAwesome.Sharp.IconButton();
            this.actualizar = new FontAwesome.Sharp.IconButton();
            this.Borrar = new FontAwesome.Sharp.IconButton();
            this.buscar = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Agregar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(153, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 367);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nombre";
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FechaDeNacimiento";
            this.Column3.HeaderText = "Fecha De Nacimiento";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Telefono";
            this.Column4.HeaderText = "Telefono";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Direccion";
            this.Column6.HeaderText = "Direccion";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "EsClienteDesde";
            this.Column5.HeaderText = "Cliente Desde";
            this.Column5.Name = "Column5";
            // 
            // Guardar
            // 
            this.Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guardar.BackgroundImage")));
            this.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Guardar.IconColor = System.Drawing.Color.Black;
            this.Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Guardar.Location = new System.Drawing.Point(12, 12);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(33, 27);
            this.Guardar.TabIndex = 0;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actualizar.BackgroundImage")));
            this.actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.actualizar.IconColor = System.Drawing.Color.Black;
            this.actualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actualizar.Location = new System.Drawing.Point(51, 12);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(27, 27);
            this.actualizar.TabIndex = 1;
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Borrar.BackgroundImage")));
            this.Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Borrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Borrar.IconColor = System.Drawing.Color.Black;
            this.Borrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Borrar.Location = new System.Drawing.Point(84, 12);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(31, 27);
            this.Borrar.TabIndex = 2;
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // buscar
            // 
            this.buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buscar.BackgroundImage")));
            this.buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buscar.IconColor = System.Drawing.Color.Black;
            this.buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buscar.Location = new System.Drawing.Point(558, 33);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(22, 23);
            this.buscar.TabIndex = 3;
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Agregar
            // 
            this.Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agregar.BackgroundImage")));
            this.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Agregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Agregar.IconColor = System.Drawing.Color.Black;
            this.Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregar.Location = new System.Drawing.Point(121, 12);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(30, 27);
            this.Agregar.TabIndex = 5;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha DE nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dirreccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha De Inscripcion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(7, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(7, 284);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(7, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(7, 236);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(7, 323);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(140, 20);
            this.textBox7.TabIndex = 17;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton Guardar;
        private FontAwesome.Sharp.IconButton actualizar;
        private FontAwesome.Sharp.IconButton Borrar;
        private FontAwesome.Sharp.IconButton buscar;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
    }
}

