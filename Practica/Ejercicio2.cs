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
    public partial class Ejercicio2 : Form
    {
        int[] lista = new int[30];
        private ListBox lstNumeros;

        public Ejercicio2()
        {
            InitializeComponent();
            lstNumeros = listBox1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            lstNumeros.Items.Clear();

            for (int i = 0; i < 30; i++)
            {
                lista[i] = r.Next(1, 101);
            }

            Array.Sort(lista);

            for (int i = 0; i < 30; i++)
            {
                lstNumeros.Items.Add(lista[i]);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscado = int.Parse(txtBuscar.Text);
            int inicio = 0;
            int fin = 29;
            bool encontrado = false;

            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;

                if (lista[mitad] == buscado)
                {
                    MessageBox.Show("Encontrado en la posición: " + mitad);
                    encontrado = true;
                    break;
                }

                if (buscado < lista[mitad])
                {
                    fin = mitad - 1;
                }
                else
                {
                    inicio = mitad + 1;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("El número no está en la lista");
            }
        }
    }
}
