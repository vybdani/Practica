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
    public partial class Ejercicio4 : Form
    {
        List<Estudiante> lista = new List<Estudiante>();
        public class Estudiante
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtIdNuevo.Text == "" || txtNombreNuevo.Text == "") return;

            Estudiante nuevo = new Estudiante();
            nuevo.Id = int.Parse(txtIdNuevo.Text);
            nuevo.Nombre = txtNombreNuevo.Text;

            lista.Add(nuevo);
            lstEstudiantes.Items.Add(nuevo.Id + " - " + nuevo.Nombre);

            txtIdNuevo.Clear();
            txtNombreNuevo.Clear();
            txtIdNuevo.Focus();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            if (txtIdBuscar.Text == "") return;

            int idBuscado = int.Parse(txtIdBuscar.Text);
            bool encontrado = false;

            foreach (Estudiante est in lista)
            {
                if (est.Id == idBuscado)
                {
                    MessageBox.Show("Encontrado: " + est.Nombre);
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("ID no encontrado");
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (txtNombreBuscar.Text == "") return;

            string buscado = txtNombreBuscar.Text;

            lista.Sort((x, y) => x.Nombre.CompareTo(y.Nombre));

            lstEstudiantes.Items.Clear();
            foreach (Estudiante est in lista)
            {
                lstEstudiantes.Items.Add(est.Id + " - " + est.Nombre);
            }

            int inicio = 0;
            int fin = lista.Count - 1;
            bool encontrado = false;

            while (inicio <= fin)
            {
                int mitad = (inicio + fin) / 2;
                string nombreCentro = lista[mitad].Nombre;
                int comparacion = nombreCentro.CompareTo(buscado);

                if (comparacion == 0)
                {
                    MessageBox.Show("Encontrado ID: " + lista[mitad].Id);
                    encontrado = true;
                    break;
                }

                if (comparacion < 0)
                {
                    inicio = mitad + 1;
                }
                else
                {
                    fin = mitad - 1;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("Nombre no encontrado");
            }
        }
    }
}
