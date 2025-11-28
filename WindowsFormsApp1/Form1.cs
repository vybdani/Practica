using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        List<Libro> biblioteca = new List<Libro>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            biblioteca.Add(new Libro { Titulo = "Cien anios de soledad", Autor = "Gabriel Garcia", Anio = 1967, Descripcion = "Novela sobre la familia Buendia" });
            biblioteca.Add(new Libro { Titulo = "Don Quijote", Autor = "Miguel de Cervantes", Anio = 1605, Descripcion = "Un hidalgo que se cree caballero" });
            biblioteca.Add(new Libro { Titulo = "Harry Potter", Autor = "JK Rowling", Anio = 1997, Descripcion = "Un niño mago va a una escuela" });
            biblioteca.Add(new Libro { Titulo = "El Principito", Autor = "Antoine Saint", Anio = 1943, Descripcion = "Un aviador conoce a un niño" });
            biblioteca.Add(new Libro { Titulo = "1984", Autor = "George Orwell", Anio = 1949, Descripcion = "Historia sobre el control total" });

            ActualizarTabla();  
        }
        private void ActualizarTabla()
        {
            dgvBiblioteca.Rows.Clear();

            foreach (var libro in biblioteca)
            {
                dgvBiblioteca.Rows.Add(libro.Titulo, libro.Autor, libro.Anio, libro.Descripcion);
            }
        }




        private void btnBuscarTitulo_Click(object sender, EventArgs e)
        {
            string tituloBuscado = txtTitulo.Text.ToLower();
            bool encontrado = false;
            foreach (var libro in biblioteca)
            {
                if (libro.Titulo.ToLower().Contains(tituloBuscado))
                {
                    MessageBox.Show($"Libro encontrado:\nTítulo: {libro.Titulo}\nAutor: {libro.Autor}\nAño: {libro.Anio}\nDescripción: {libro.Descripcion}");
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado == false)
            {
                MessageBox.Show("Libro no encontrado.");
            }
        }

        public class Libro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Anio { get; set; }
            public string Descripcion { get; set; }
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < biblioteca.Count - 1; i++)
            {
                for (int j = 0; j < biblioteca.Count - i - 1; j++)
                {
                    if (string.Compare(biblioteca[j].Autor, biblioteca[j + 1].Autor) > 0)
                    {
                        Libro temp = biblioteca[j];
                        biblioteca[j] = biblioteca[j + 1];
                        biblioteca[j + 1] = temp;
                    }
                }
            }

            ActualizarTabla();

            string buscado = txtAutor.Text;
            int inicio = 0;
            int fin = biblioteca.Count - 1;
            bool encontrado = false;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;
                int comparacion = string.Compare(biblioteca[medio].Autor, buscado);

                if (comparacion == 0)
                {
                    MessageBox.Show("¡Encontrado\nLibro: " + biblioteca[medio].Titulo);
                    encontrado = true;
                    break;
                }

                if (comparacion < 0) inicio = medio + 1;
                else fin = medio - 1;
            }

            if (encontrado == false) MessageBox.Show("Autor no encontrado");
        }

        private void btnExtremos_Click(object sender, EventArgs e)
        {
            if (biblioteca.Count == 0) return;

            Libro masViejo = biblioteca[0];
            Libro masNuevo = biblioteca[0];

            foreach (Libro libro in biblioteca)
            {
                if (libro.Anio < masViejo.Anio) masViejo = libro;
                if (libro.Anio > masNuevo.Anio) masNuevo = libro;
            }

            MessageBox.Show("Más Viejo: " + masViejo.Titulo + " (" + masViejo.Anio + ")\n" +
                            "Más Nuevo: " + masNuevo.Titulo + " (" + masNuevo.Anio + ")");
        }

        private void btnBuscarDesc_Click(object sender, EventArgs e)
        {
            string palabra = txtDescripcion.Text.ToLower();
            string resultados = "";

            foreach (Libro libro in biblioteca)
            {
                string texto = libro.Descripcion.ToLower();
                bool contiene = false;

                // Algoritmo manual para buscar texto dentro de texto
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
                    if (coincide)
                    {
                        contiene = true;
                        break;
                    }
                }

                if (contiene) resultados += "- " + libro.Titulo + "\n";
            }

            if (resultados != "") MessageBox.Show("Encontrado en:\n" + resultados);
            else MessageBox.Show("Ninguna descripción tiene esa palabra");
        }

        private void dgvBiblioteca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExtremos_Click_1(object sender, EventArgs e)
        {
            if (biblioteca.Count == 0) return;

            Libro masViejo = biblioteca[0];
            Libro masNuevo = biblioteca[0];

            foreach (Libro libro in biblioteca)
            {
                if (libro.Anio < masViejo.Anio) masViejo = libro;
                if (libro.Anio > masNuevo.Anio) masNuevo = libro;
            }

            MessageBox.Show($"Más Viejo: {masViejo.Titulo} ({masViejo.Anio})\nMás Nuevo: {masNuevo.Titulo} ({masNuevo.Anio})");
        }

        private void btnBuscarDesc_Click_1(object sender, EventArgs e)
        {
            string palabra = txtDescripcion.Text.ToLower();
            string resultados = "";

            foreach (Libro libro in biblioteca)
            {
                string texto = libro.Descripcion.ToLower();
                bool contiene = false;

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
                    if (coincide)
                    {
                        contiene = true;
                        break;
                    }
                }

                if (contiene)
                {
                    resultados += "- " + libro.Titulo + "\n";
                }
            }

            if (resultados != "")
            {
                MessageBox.Show("Encontrado en:\n" + resultados);
            }
            else
            {
                MessageBox.Show("Ninguna descripción tiene esa palabra");
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
