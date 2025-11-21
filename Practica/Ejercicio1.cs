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
    public partial class Ejercicio1 : Form
    {
        int[] numeros = new int[20];

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lstNumeros.Items.Clear();

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = rnd.Next(1, 101);
                lstNumeros.Items.Add(numeros[i]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Escribe un número primero.");
                return;
            }

            int numeroBuscado = int.Parse(txtBuscar.Text);
            bool encontrado = false;

            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] == numeroBuscado)
                {
                    MessageBox.Show("¡Encontrado! El número " + numeroBuscado + " está en la posición " + i);
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("El número no existe en el arreglo.");
            }
        }
    }
}
