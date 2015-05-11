using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_CodigoQR
{
    public partial class FormVisualizarQR : Form
    {
        public FormVisualizarQR(Image imagenQR)
        {
            InitializeComponent();
            Inicializar(imagenQR);
        }

        private void Inicializar(Image imagenQR)
        {
            pbxVerQR.Image = imagenQR;
        }
    }
}
