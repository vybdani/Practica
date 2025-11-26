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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            string texto = txtParrafo.Text.ToLower();
            string palabra = txtPalabra.Text.ToLower();

            if (texto == "" || palabra == "")
            {
                MessageBox.Show("Llena ambos campos");
                return;
            }

            int contador = 0;

            for (int i = 0; i <= texto.Length - palabra.Length; i++)
            {
                bool coincide = true;

                for (int j = 0; j < palabra.Length; j++)
                {
                    if (texto[i + j] != palabra[j])
                    {
                        coincide = false;
                        break;
                    }
                }

                if (coincide == true)
                {
                    contador++;
                }
            }

            MessageBox.Show("Aparece: " + contador + " veces");
        }
    }
}
