namespace App_CodigoQR
{
    partial class FormVisualizarQR
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
            this.pbxVerQR = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbxVerQR);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 342);
            this.panel1.TabIndex = 0;
            // 
            // pbxVerQR
            // 
            this.pbxVerQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxVerQR.Location = new System.Drawing.Point(0, 0);
            this.pbxVerQR.Name = "pbxVerQR";
            this.pbxVerQR.Size = new System.Drawing.Size(400, 342);
            this.pbxVerQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVerQR.TabIndex = 0;
            this.pbxVerQR.TabStop = false;
            // 
            // FormVisualizarQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 342);
            this.Controls.Add(this.panel1);
            this.Name = "FormVisualizarQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visualizador QR";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxVerQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxVerQR;
    }
}