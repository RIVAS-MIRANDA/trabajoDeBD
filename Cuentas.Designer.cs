namespace trabajoDeBD
{
    partial class Cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuentas));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idusuario = new System.Windows.Forms.TextBox();
            this.idcuenta = new System.Windows.Forms.TextBox();
            this.tipocuenta = new System.Windows.Forms.TextBox();
            this.saldo = new System.Windows.Forms.TextBox();
            this.fechacrecion = new System.Windows.Forms.TextBox();
            this.txbuscar = new System.Windows.Forms.TextBox();
            this.Guardar = new FontAwesome.Sharp.IconButton();
            this.Actualizar = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new FontAwesome.Sharp.IconButton();
            this.Agregar = new FontAwesome.Sharp.IconButton();
            this.Buscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView.Location = new System.Drawing.Point(147, 61);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(651, 388);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDUsuario";
            this.Column1.HeaderText = "ID Usuario";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IDCuenta";
            this.Column2.HeaderText = "ID Cuenta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TipoCuenta";
            this.Column3.HeaderText = "Tipo De Cuenta";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Saldo";
            this.Column4.HeaderText = "Saldo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FechaDeCreacion";
            this.Column5.HeaderText = "Fecha De Creacion";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo De Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha De Creacion";
            // 
            // idusuario
            // 
            this.idusuario.Location = new System.Drawing.Point(6, 106);
            this.idusuario.Name = "idusuario";
            this.idusuario.Size = new System.Drawing.Size(135, 20);
            this.idusuario.TabIndex = 6;
            // 
            // idcuenta
            // 
            this.idcuenta.Location = new System.Drawing.Point(6, 161);
            this.idcuenta.Name = "idcuenta";
            this.idcuenta.Size = new System.Drawing.Size(135, 20);
            this.idcuenta.TabIndex = 7;
            // 
            // tipocuenta
            // 
            this.tipocuenta.Location = new System.Drawing.Point(6, 208);
            this.tipocuenta.Name = "tipocuenta";
            this.tipocuenta.Size = new System.Drawing.Size(135, 20);
            this.tipocuenta.TabIndex = 8;
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(6, 259);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(135, 20);
            this.saldo.TabIndex = 9;
            // 
            // fechacrecion
            // 
            this.fechacrecion.Location = new System.Drawing.Point(6, 309);
            this.fechacrecion.Name = "fechacrecion";
            this.fechacrecion.Size = new System.Drawing.Size(135, 20);
            this.fechacrecion.TabIndex = 10;
            // 
            // txbuscar
            // 
            this.txbuscar.Location = new System.Drawing.Point(351, 24);
            this.txbuscar.Name = "txbuscar";
            this.txbuscar.Size = new System.Drawing.Size(187, 20);
            this.txbuscar.TabIndex = 11;
            // 
            // Guardar
            // 
            this.Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guardar.BackgroundImage")));
            this.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Guardar.IconColor = System.Drawing.Color.Black;
            this.Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Guardar.Location = new System.Drawing.Point(6, 6);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(39, 29);
            this.Guardar.TabIndex = 12;
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Actualizar.BackgroundImage")));
            this.Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Actualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Actualizar.IconColor = System.Drawing.Color.Black;
            this.Actualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Actualizar.Location = new System.Drawing.Point(51, 6);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(33, 30);
            this.Actualizar.TabIndex = 13;
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminar.BackgroundImage")));
            this.Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Eliminar.IconColor = System.Drawing.Color.Black;
            this.Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Eliminar.Location = new System.Drawing.Point(90, 6);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(36, 29);
            this.Eliminar.TabIndex = 14;
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agregar.BackgroundImage")));
            this.Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Agregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Agregar.IconColor = System.Drawing.Color.Black;
            this.Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Agregar.Location = new System.Drawing.Point(132, 7);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(36, 29);
            this.Agregar.TabIndex = 15;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscar.BackgroundImage")));
            this.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Buscar.IconColor = System.Drawing.Color.Black;
            this.Buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Buscar.Location = new System.Drawing.Point(544, 22);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(31, 23);
            this.Buscar.TabIndex = 16;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.txbuscar);
            this.Controls.Add(this.fechacrecion);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.tipocuenta);
            this.Controls.Add(this.idcuenta);
            this.Controls.Add(this.idusuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Name = "Cuentas";
            this.Text = "cuenta";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idusuario;
        private System.Windows.Forms.TextBox idcuenta;
        private System.Windows.Forms.TextBox tipocuenta;
        private System.Windows.Forms.TextBox saldo;
        private System.Windows.Forms.TextBox fechacrecion;
        private System.Windows.Forms.TextBox txbuscar;
        private FontAwesome.Sharp.IconButton Guardar;
        private FontAwesome.Sharp.IconButton Actualizar;
        private FontAwesome.Sharp.IconButton Eliminar;
        private FontAwesome.Sharp.IconButton Agregar;
        private FontAwesome.Sharp.IconButton Buscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}