namespace pryRodriguezCadenasTexto
{
    partial class frmCadenasTexto
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
            this.lblTextoA = new System.Windows.Forms.Label();
            this.lblTextoB = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidadA = new System.Windows.Forms.Label();
            this.lblCantidadB = new System.Windows.Forms.Label();
            this.txtTextoA = new System.Windows.Forms.TextBox();
            this.txtTextoB = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnReemplazar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConveritr = new System.Windows.Forms.Button();
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTextoA
            // 
            this.lblTextoA.AutoSize = true;
            this.lblTextoA.Location = new System.Drawing.Point(47, 49);
            this.lblTextoA.Name = "lblTextoA";
            this.lblTextoA.Size = new System.Drawing.Size(53, 16);
            this.lblTextoA.TabIndex = 0;
            this.lblTextoA.Text = "Texto A";
            // 
            // lblTextoB
            // 
            this.lblTextoB.AutoSize = true;
            this.lblTextoB.Location = new System.Drawing.Point(47, 115);
            this.lblTextoB.Name = "lblTextoB";
            this.lblTextoB.Size = new System.Drawing.Size(53, 16);
            this.lblTextoB.TabIndex = 1;
            this.lblTextoB.Text = "Texto B";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(47, 195);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCantidadA
            // 
            this.lblCantidadA.AutoSize = true;
            this.lblCantidadA.Location = new System.Drawing.Point(411, 49);
            this.lblCantidadA.Name = "lblCantidadA";
            this.lblCantidadA.Size = new System.Drawing.Size(14, 16);
            this.lblCantidadA.TabIndex = 3;
            this.lblCantidadA.Text = "0";
            // 
            // lblCantidadB
            // 
            this.lblCantidadB.AutoSize = true;
            this.lblCantidadB.Location = new System.Drawing.Point(411, 121);
            this.lblCantidadB.Name = "lblCantidadB";
            this.lblCantidadB.Size = new System.Drawing.Size(14, 16);
            this.lblCantidadB.TabIndex = 4;
            this.lblCantidadB.Text = "0";
            // 
            // txtTextoA
            // 
            this.txtTextoA.Location = new System.Drawing.Point(167, 42);
            this.txtTextoA.Name = "txtTextoA";
            this.txtTextoA.Size = new System.Drawing.Size(195, 22);
            this.txtTextoA.TabIndex = 5;
            this.txtTextoA.TextChanged += new System.EventHandler(this.txtTextoA_TextChanged);
            // 
            // txtTextoB
            // 
            this.txtTextoB.Location = new System.Drawing.Point(167, 115);
            this.txtTextoB.Name = "txtTextoB";
            this.txtTextoB.Size = new System.Drawing.Size(195, 22);
            this.txtTextoB.TabIndex = 6;
            this.txtTextoB.TextChanged += new System.EventHandler(this.txtTextoB_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(162, 195);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(50, 272);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(89, 33);
            this.btnComparar.TabIndex = 8;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnReemplazar
            // 
            this.btnReemplazar.Location = new System.Drawing.Point(198, 272);
            this.btnReemplazar.Name = "btnReemplazar";
            this.btnReemplazar.Size = new System.Drawing.Size(91, 33);
            this.btnReemplazar.TabIndex = 9;
            this.btnReemplazar.Text = "Reemplazar";
            this.btnReemplazar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(50, 342);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 33);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConveritr
            // 
            this.btnConveritr.Location = new System.Drawing.Point(50, 437);
            this.btnConveritr.Name = "btnConveritr";
            this.btnConveritr.Size = new System.Drawing.Size(89, 31);
            this.btnConveritr.TabIndex = 11;
            this.btnConveritr.Text = "Convertir";
            this.btnConveritr.UseVisualStyleBackColor = true;
            this.btnConveritr.Click += new System.EventHandler(this.btnConveritr_Click);
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.Location = new System.Drawing.Point(195, 440);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(45, 16);
            this.lblMostrarFecha.TabIndex = 12;
            this.lblMostrarFecha.Text = "Fecha";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(198, 352);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(91, 22);
            this.txtBuscar.TabIndex = 13;
            // 
            // frmCadenasTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 533);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblMostrarFecha);
            this.Controls.Add(this.btnConveritr);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnReemplazar);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtTextoB);
            this.Controls.Add(this.txtTextoA);
            this.Controls.Add(this.lblCantidadB);
            this.Controls.Add(this.lblCantidadA);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTextoB);
            this.Controls.Add(this.lblTextoA);
            this.Name = "frmCadenasTexto";
            this.Text = "Cadenas de texto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoA;
        private System.Windows.Forms.Label lblTextoB;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidadA;
        private System.Windows.Forms.Label lblCantidadB;
        private System.Windows.Forms.TextBox txtTextoA;
        private System.Windows.Forms.TextBox txtTextoB;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnReemplazar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConveritr;
        private System.Windows.Forms.Label lblMostrarFecha;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}

