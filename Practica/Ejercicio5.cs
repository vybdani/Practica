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
    public partial class Ejercicio5 : Form
    {
        List<int> lista = new List<int>();
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lista.Clear();
            lstNumeros.Items.Clear();

            for (int i = 0; i < 20; i++)
            {
                int numero = rnd.Next(1, 101);
                lista.Add(numero);
                lstNumeros.Items.Add(numero);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                MessageBox.Show("Primero genera la lista");
                return;
            }

            int mayor = lista[0];
            int menor = lista[0];
            int contador = 0;

            foreach (int numero in lista)
            {
                contador++;

                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            lblMax.Text = mayor.ToString();
            lblMin.Text = menor.ToString();
            lblIteraciones.Text = contador.ToString();
        }
    }
}
