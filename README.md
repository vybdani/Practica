# Sistema de Búsqueda para Biblioteca Digital

Proyecto para la asignatura de Programación Estructurada (UAM).

Este es un prototipo de aplicación de escritorio hecho en C# (Windows Forms) que simula el sistema de búsqueda de una biblioteca. El objetivo principal fue implementar algoritmos de búsqueda y ordenamiento de forma manual, sin utilizar las funciones automáticas de .NET (como .Sort o .Contains), para demostrar el funcionamiento lógico de las estructuras de datos.

## Integrantes
* Daniella Alexandra Rocha Palacios
* Franklin Isaac Callejas Treminio

## Funcionalidades del Proyecto

El sistema permite gestionar una lista de libros y realizar las siguientes operaciones:

1. Búsqueda Lineal por Título
Busca un libro comparando el título ingresado con cada elemento de la lista hasta encontrar una coincidencia exacta.

2. Búsqueda Binaria por Autor
Permite buscar libros por nombre de autor de forma rápida.
Nota: Como la búsqueda binaria requiere datos ordenados, implementamos un algoritmo de Ordenamiento Burbuja que organiza la lista alfabéticamente por autor antes de realizar la búsqueda.

3. Reporte de Extremos
Recorre toda la colección para identificar y mostrar cuál es el libro más antiguo y cuál es el más reciente según el año de publicación.

4. Búsqueda en Descripción (Texto)
Busca palabras clave dentro de la descripción de los libros. Se implementó un algoritmo manual que compara carácter por carácter para encontrar coincidencias sin usar métodos predefinidos.

## Tecnologías
* C#
* Windows Forms (.NET Framework)
* Visual Studio 2022

## Cómo ejecutar el proyecto

1. Clonar este repositorio o descargar el código como ZIP.
2. Abrir el archivo de solución (.sln) con Visual Studio.
3. Selecionar la rama Caso-De-Estudio
4. Presionar F5 o el botón de Iniciar para compilar y ejecutar.
5. Usar los botones de la interfaz para probar los distintos algoritmos con los datos de prueba ya cargados.
