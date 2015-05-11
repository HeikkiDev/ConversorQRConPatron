namespace App_CodigoQR
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblOcupación = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxOcupacion = new System.Windows.Forms.TextBox();
            this.mtbxFecha = new System.Windows.Forms.MaskedTextBox();
            this.pbxCodigoQR = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.toolTipImagenQR = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodigoQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(27, 79);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 16);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(27, 141);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(133, 16);
            this.lblFechaNac.TabIndex = 2;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(27, 203);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 16);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblOcupación
            // 
            this.lblOcupación.AutoSize = true;
            this.lblOcupación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcupación.Location = new System.Drawing.Point(27, 265);
            this.lblOcupación.Name = "lblOcupación";
            this.lblOcupación.Size = new System.Drawing.Size(73, 16);
            this.lblOcupación.TabIndex = 4;
            this.lblOcupación.Text = "Ocupación";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(30, 36);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(331, 26);
            this.tbxNombre.TabIndex = 5;
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxApellidos.Location = new System.Drawing.Point(30, 99);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(331, 26);
            this.tbxApellidos.TabIndex = 6;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTelefono.Location = new System.Drawing.Point(30, 225);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(148, 26);
            this.tbxTelefono.TabIndex = 8;
            // 
            // tbxOcupacion
            // 
            this.tbxOcupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOcupacion.Location = new System.Drawing.Point(30, 288);
            this.tbxOcupacion.Name = "tbxOcupacion";
            this.tbxOcupacion.Size = new System.Drawing.Size(331, 26);
            this.tbxOcupacion.TabIndex = 9;
            // 
            // mtbxFecha
            // 
            this.mtbxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbxFecha.Location = new System.Drawing.Point(30, 160);
            this.mtbxFecha.Mask = "00/00/0000";
            this.mtbxFecha.Name = "mtbxFecha";
            this.mtbxFecha.Size = new System.Drawing.Size(103, 26);
            this.mtbxFecha.TabIndex = 10;
            this.mtbxFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbxFecha.ValidatingType = typeof(System.DateTime);
            // 
            // pbxCodigoQR
            // 
            this.pbxCodigoQR.BackColor = System.Drawing.Color.White;
            this.pbxCodigoQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxCodigoQR.Location = new System.Drawing.Point(426, 36);
            this.pbxCodigoQR.Name = "pbxCodigoQR";
            this.pbxCodigoQR.Size = new System.Drawing.Size(246, 225);
            this.pbxCodigoQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCodigoQR.TabIndex = 11;
            this.pbxCodigoQR.TabStop = false;
            this.toolTipImagenQR.SetToolTip(this.pbxCodigoQR, "Haga click para ampliar.");
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(451, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 32);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(559, 279);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 32);
            this.btnImprimir.TabIndex = 13;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(30, 344);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Borrar todo";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(196, 334);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(177, 33);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar QR";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // toolTipImagenQR
            // 
            this.toolTipImagenQR.AutoPopDelay = 10000;
            this.toolTipImagenQR.InitialDelay = 100;
            this.toolTipImagenQR.ReshowDelay = 100;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(698, 379);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbxCodigoQR);
            this.Controls.Add(this.mtbxFecha);
            this.Controls.Add(this.tbxOcupacion);
            this.Controls.Add(this.tbxTelefono);
            this.Controls.Add(this.tbxApellidos);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblOcupación);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Codificador QR";
            this.Shown += new System.EventHandler(this.FormPrincipal_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCodigoQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblOcupación;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxOcupacion;
        private System.Windows.Forms.MaskedTextBox mtbxFecha;
        private System.Windows.Forms.PictureBox pbxCodigoQR;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ToolTip toolTipImagenQR;
    }
}

