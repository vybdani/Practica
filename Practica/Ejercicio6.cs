using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Ejercicio6 : Form
    {
        int[,] matriz = new int[10, 10];
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rtbMatriz.Clear();
            string contenido = "";

            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    matriz[f, c] = rnd.Next(1, 100);
                    contenido += matriz[f, c] + "\t";
                }
                contenido += "\n";
            }

            rtbMatriz.Text = contenido;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "") return;

            int buscado = int.Parse(txtNumero.Text);
            bool encontrado = false;
            string posiciones = "";

            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    if (matriz[f, c] == buscado)
                    {
                        posiciones += "Fila " + f + ", Columna " + c + "\n";
                        encontrado = true;
                    }
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Encontrado en:\n" + posiciones);
            }
            else
            {
                MessageBox.Show("El número no está en la matriz.");
            }
        }
    }
}
