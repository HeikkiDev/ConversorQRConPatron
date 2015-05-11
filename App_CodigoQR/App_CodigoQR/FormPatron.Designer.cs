namespace App_CodigoQR
{
    partial class FormPatron
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
            this.components = new System.ComponentModel.Container();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(172, 9);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(49, 18);
            this.lblAyuda.TabIndex = 0;
            this.lblAyuda.Text = "Ayuda";
            this.toolTipAyuda.SetToolTip(this.lblAyuda, "El patrón por defecto es una Z.\r\nPara desbloquear mantenga el click izquierdo del" +
        " ratón para hacer el recorrido del patrón.");
            // 
            // toolTipAyuda
            // 
            this.toolTipAyuda.AutoPopDelay = 10000;
            this.toolTipAyuda.InitialDelay = 100;
            this.toolTipAyuda.ReshowDelay = 100;
            // 
            // FormPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(414, 368);
            this.Controls.Add(this.lblAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormPatron";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatron";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPatron_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormPatron_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormPatron_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormPatron_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.ToolTip toolTipAyuda;
    }
}