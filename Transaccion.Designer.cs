namespace trabajoDeBD
{
    partial class Transaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaccion));
            this.Datatransaccion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardar = new FontAwesome.Sharp.IconButton();
            this.Actualizar = new FontAwesome.Sharp.IconButton();
            this.Eliminar = new FontAwesome.Sharp.IconButton();
            this.Agregar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.texttransaccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textidcuentas = new System.Windows.Forms.TextBox();
            this.texttipotransaccion = new System.Windows.Forms.TextBox();
            this.textmonto = new System.Windows.Forms.TextBox();
            this.textfechatransaccion = new System.Windows.Forms.TextBox();
            this.textubicacion = new System.Windows.Forms.TextBox();
            this.Buscar = new FontAwesome.Sharp.IconButton();
            this.texbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Datatransaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // Datatransaccion
            // 
            this.Datatransaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datatransaccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Datatransaccion.Location = new System.Drawing.Point(159, 58);
            this.Datatransaccion.Name = "Datatransaccion";
            this.Datatransaccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datatransaccion.Size = new System.Drawing.Size(638, 392);
            this.Datatransaccion.TabIndex = 0;
            this.Datatransaccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datatransaccion_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDTransaccion";
            this.Column1.HeaderText = "ID-Transaccion";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IDCuentas";
            this.Column2.HeaderText = "ID-Cuenta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TipoTransaccion";
            this.Column3.HeaderText = "Tipo De Transaccion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Monto";
            this.Column4.HeaderText = "Monto";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "FechaDeTransaccion";
            this.Column5.HeaderText = "Fecha De Transaccion";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Ubicacion";
            this.Column6.HeaderText = "Ubicacion";
            this.Column6.Name = "Column6";
            // 
            // Guardar
            // 
            this.Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guardar.BackgroundImage")));
            this.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Guardar.IconColor = System.Drawing.Color.Black;
            this.Guardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Guardar.Location = new System.Drawing.Point(2, 2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(29, 27);
            this.Guardar.TabIndex = 1;
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
            this.Actualizar.Location = new System.Drawing.Point(37, 2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(31, 27);
            this.Actualizar.TabIndex = 2;
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
            this.Eliminar.Location = new System.Drawing.Point(74, 2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(33, 27);
            this.Eliminar.TabIndex = 3;
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
            this.Agregar.Location = new System.Drawing.Point(113, 2);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(32, 27);
            this.Agregar.TabIndex = 4;
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID_Transaccion";
            // 
            // texttransaccion
            // 
            this.texttransaccion.Location = new System.Drawing.Point(7, 74);
            this.texttransaccion.Name = "texttransaccion";
            this.texttransaccion.Size = new System.Drawing.Size(146, 20);
            this.texttransaccion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID_Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo_De_transaccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha_De_Transaccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ubication";
            // 
            // textidcuentas
            // 
            this.textidcuentas.Location = new System.Drawing.Point(7, 125);
            this.textidcuentas.Name = "textidcuentas";
            this.textidcuentas.Size = new System.Drawing.Size(146, 20);
            this.textidcuentas.TabIndex = 12;
            // 
            // texttipotransaccion
            // 
            this.texttipotransaccion.Location = new System.Drawing.Point(7, 176);
            this.texttipotransaccion.Name = "texttipotransaccion";
            this.texttipotransaccion.Size = new System.Drawing.Size(146, 20);
            this.texttipotransaccion.TabIndex = 13;
            // 
            // textmonto
            // 
            this.textmonto.Location = new System.Drawing.Point(7, 229);
            this.textmonto.Name = "textmonto";
            this.textmonto.Size = new System.Drawing.Size(146, 20);
            this.textmonto.TabIndex = 14;
            // 
            // textfechatransaccion
            // 
            this.textfechatransaccion.Location = new System.Drawing.Point(7, 277);
            this.textfechatransaccion.Name = "textfechatransaccion";
            this.textfechatransaccion.Size = new System.Drawing.Size(146, 20);
            this.textfechatransaccion.TabIndex = 15;
            // 
            // textubicacion
            // 
            this.textubicacion.Location = new System.Drawing.Point(7, 326);
            this.textubicacion.Name = "textubicacion";
            this.textubicacion.Size = new System.Drawing.Size(146, 20);
            this.textubicacion.TabIndex = 16;
            // 
            // Buscar
            // 
            this.Buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscar.BackgroundImage")));
            this.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Buscar.IconColor = System.Drawing.Color.Black;
            this.Buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Buscar.Location = new System.Drawing.Point(571, 12);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(24, 23);
            this.Buscar.TabIndex = 17;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click_1);
            // 
            // texbuscar
            // 
            this.texbuscar.Location = new System.Drawing.Point(403, 15);
            this.texbuscar.Name = "texbuscar";
            this.texbuscar.Size = new System.Drawing.Size(162, 20);
            this.texbuscar.TabIndex = 18;
            // 
            // Transaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texbuscar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.textubicacion);
            this.Controls.Add(this.textfechatransaccion);
            this.Controls.Add(this.textmonto);
            this.Controls.Add(this.texttipotransaccion);
            this.Controls.Add(this.textidcuentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texttransaccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Datatransaccion);
            this.Name = "Transaccion";
            this.Text = "Transaccion";
            this.Load += new System.EventHandler(this.Transaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datatransaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datatransaccion;
        private FontAwesome.Sharp.IconButton Guardar;
        private FontAwesome.Sharp.IconButton Actualizar;
        private FontAwesome.Sharp.IconButton Eliminar;
        private FontAwesome.Sharp.IconButton Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texttransaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textidcuentas;
        private System.Windows.Forms.TextBox texttipotransaccion;
        private System.Windows.Forms.TextBox textmonto;
        private System.Windows.Forms.TextBox textfechatransaccion;
        private System.Windows.Forms.TextBox textubicacion;
        private FontAwesome.Sharp.IconButton Buscar;
        private System.Windows.Forms.TextBox texbuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}