using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//
using ZXing;
using ZXing.QrCode;
using System.Drawing.Printing;
//

namespace App_CodigoQR
{

    public partial class FormPrincipal : Form
    {
        string ruta = @"Dependencias\logoQR.png";
        string cadena;
        Bitmap bmp;
        //Variables para el patrón
        FormPatron patron;
        public static string cadenaPatron;
        ////

        public FormPrincipal()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            cadena = string.Empty;
            pbxCodigoQR.SizeMode = PictureBoxSizeMode.CenterImage;
            pbxCodigoQR.Image = Image.FromFile(ruta);
            tbxNombre.Clear();
            tbxApellidos.Clear();
            tbxTelefono.Clear();
            tbxOcupacion.Clear();
            mtbxFecha.Clear();
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = false;
            tbxNombre.Select();
            //Patrón
            cadenaPatron = "ABCEGHI";
        }

        #region PATRON
        private void MostrarPatron()
        {
            patron = new FormPatron();
            patron.CerrarPadre += patron_CerrarPadre;
            patron.ShowDialog();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            MostrarPatron();
        }

        void patron_CerrarPadre()
        {
            this.Close();
        }
        #endregion

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cadena = tbxNombre.Text + "\n" + tbxApellidos.Text + "\n" + mtbxFecha.Text + "\n" + tbxTelefono.Text + "\n" + tbxOcupacion.Text;
            
            QRCodeWriter codificador = new QRCodeWriter();
            
            bmp = codificador.encode(cadena, ZXing.BarcodeFormat.QR_CODE,pbxCodigoQR.Width,pbxCodigoQR.Height).ToBitmap(ZXing.BarcodeFormat.QR_CODE, cadena);
            
            pbxCodigoQR.SizeMode=PictureBoxSizeMode.StretchImage;
            pbxCodigoQR.Image = bmp;

            btnGuardar.Enabled = true;
            btnImprimir.Enabled = true;

            pbxCodigoQR.Click += pbxCodigoQR_Click;
        }

        void pbxCodigoQR_Click(object sender, EventArgs e)
        {
            FormVisualizarQR formVQR = new FormVisualizarQR(bmp);
            formVQR.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Bitmap imagen = new Bitmap(pbxCodigoQR.Image, 300, 300);
            SaveFileDialog guardarImagen = new SaveFileDialog();
            guardarImagen.Filter = "Imágenes (*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF";
            if (guardarImagen.ShowDialog() == DialogResult.OK)
            {
                imagen.Save(guardarImagen.FileName);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDialog imprimir = new PrintDialog();
            PrintDocument docToPrint = new PrintDocument();

            docToPrint.PrintPage += docToPrint_PrintPage;
            imprimir.ShowHelp = true;

            if (imprimir.ShowDialog() == DialogResult.OK)
            {
                docToPrint.PrinterSettings = imprimir.PrinterSettings;
                docToPrint.Print();
            }

        }

        //Esto le indica al objeto de PrintDocument la imagen a imprimir
        void docToPrint_PrintPage(object sender, PrintPageEventArgs e) // Se lanza cuando se va imprimir
        {
            e.Graphics.DrawImage(pbxCodigoQR.Image, 0, 0);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

    }
}
