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
    public delegate void Cerrar();

    public partial class FormPatron : Form
    {
        #region CAMPOS
        Point raton;
        Point[] arrPuntos = new Point[9];
        Rectangle rect;
        Graphics grafico;
        Pen lapiz;
        int x;
        int y;
        int altura;
        int ancho;
        string cadenaCodigos;
        string resulCodigo;
        char[] arrCodigos = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I' };
        public event Cerrar CerrarPadre;
        #endregion

        public FormPatron()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            altura = 20;
            ancho = 20;
            cadenaCodigos = string.Empty;
            rect = new Rectangle(x, y, ancho, altura);
        }

        private void DibujarPuntos()
        {
            int contador = 0;

            grafico = this.CreateGraphics(); //Nuevo Graphics para el formulario

            lapiz = new Pen(Brushes.Blue, 15); //Lápiz para pintar

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    y = i * 100; //Separación entre puntos
                    x = j * 100;

                    arrPuntos[contador].X = x; //Guardo las posiciones de cada punto en un array
                    arrPuntos[contador++].Y = y;

                    rect = new Rectangle(x, y, ancho, altura); //Rectángulo en el que se dibuja el circulo
                    grafico.DrawEllipse(lapiz, rect); //Nuevo circulo en la posición del rectángulo anterior
                }
            }
        }

        private void FormPatron_Paint(object sender, PaintEventArgs e)
        {
            DibujarPuntos();
        }

        private void FormPatron_MouseMove(object sender, MouseEventArgs e)
        {
            int contador = 0;
            raton = new Point(e.X, e.Y);

            foreach (var item in arrPuntos)
            {
                if (raton.X >= item.X && raton.X <= item.X + ancho && raton.Y >= item.Y && raton.Y <= item.Y + altura)
                    cadenaCodigos += arrCodigos[contador];

                contador++;
            }
        }

        private void FormPatron_MouseDown(object sender, MouseEventArgs e)
        {
            this.MouseMove += FormPatron_MouseMove;
        }

        private void FormPatron_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= FormPatron_MouseMove;
            //
            char[] resul = cadenaCodigos.Distinct().ToArray();
            resulCodigo = new string(resul);

            if (FormPrincipal.cadenaPatron == resulCodigo)
            {
                this.Close();
            }
            else
            {
                DialogResult resultado;
                resultado = MessageBox.Show("Patrón incorrecto... ¿desea intentarlo de nuevo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes)
                    Inicializar();
                else
                    CerrarPadre();
            }
        }
      
    }
}
