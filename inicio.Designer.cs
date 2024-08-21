namespace trabajoDeBD
{
    partial class inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.cuentas = new System.Windows.Forms.Button();
            this.transaccion = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cuentas
            // 
            this.cuentas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cuentas.Location = new System.Drawing.Point(13, 13);
            this.cuentas.Name = "cuentas";
            this.cuentas.Size = new System.Drawing.Size(75, 23);
            this.cuentas.TabIndex = 0;
            this.cuentas.Text = "cuentas";
            this.cuentas.UseVisualStyleBackColor = false;
            this.cuentas.Click += new System.EventHandler(this.cuentas_Click);
            // 
            // transaccion
            // 
            this.transaccion.Location = new System.Drawing.Point(94, 13);
            this.transaccion.Name = "transaccion";
            this.transaccion.Size = new System.Drawing.Size(75, 23);
            this.transaccion.TabIndex = 1;
            this.transaccion.Text = "transaccion";
            this.transaccion.UseVisualStyleBackColor = true;
            this.transaccion.Click += new System.EventHandler(this.transaccion_Click);
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(175, 13);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(75, 23);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "usuario";
            this.usuario.UseVisualStyleBackColor = true;
            this.usuario.Click += new System.EventHandler(this.usuario_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.transaccion);
            this.Controls.Add(this.cuentas);
            this.Name = "inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cuentas;
        private System.Windows.Forms.Button transaccion;
        private System.Windows.Forms.Button usuario;
    }
}