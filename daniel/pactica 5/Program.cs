//definir  clase con nombre
// "Materia1", que tenga las siguientes propiedades (Grupo, Materia, Docente, Periodo, Hora).
//Escribir los siguientes metodos:
//DarNombre(string grupo)
//AsignarMateria(string Materia)
//DarNombre(string docente)
 
using System;
using System.Collections.Generic;
using System.Data;

namespace ListaAsistencia
{
    // Crear la clase estudiante
    public class Estudiante
    {
        // Definir las propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public bool[] Asistencia { get; set; } // Arreglo de 31 elementos, uno por cada día del mes

        // Definir el constructor
        public Estudiante(string codigo, string nombre, string carrera, bool[] asistencia)
        {
            Codigo = codigo;
            Nombre = nombre;
            Carrera = carrera;
            Asistencia = asistencia;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear la lista de estudiantes
            List<Estudiante> listaEstudiantes = new List<Estudiante>();

            // Agregar algunos estudiantes a la lista, con los datos de la captura
            // Los valores de asistencia son aleatorios, solo para fines de prueba
            listaEstudiantes.Add(new Estudiante("20190001", "Juan Perez", "Ing. Sistemas", GenerarAsistencia()));
            listaEstudiantes.Add(new Estudiante("20190002", "Ana Lopez", "Ing. Industrial", GenerarAsistencia()));
            listaEstudiantes.Add(new Estudiante("20190003", "Pedro Gomez", "Ing. Civil", GenerarAsistencia()));
            listaEstudiantes.Add(new Estudiante("20190004", "Maria Rodriguez", "Ing. Quimica", GenerarAsistencia()));
            listaEstudiantes.Add(new Estudiante("20190005", "Carlos Sanchez", "Ing. Mecanica", GenerarAsistencia()));

            // Crear la tabla en C#
            DataTable tablaAsistencia = new DataTable();

            // Agregar las columnas a la tabla
            tablaAsistencia.Columns.Add("COD");
            tablaAsistencia.Columns.Add("NOMBRE");
            tablaAsistencia.Columns.Add("CAR");
            // Agregar una columna por cada día del mes, del 1 al 31
            for (int i = 1; i <= 31; i++)
            {
                tablaAsistencia.Columns.Add(i.ToString());
            }

            // Agregar las filas a la tabla, una por cada estudiante
            foreach (Estudiante estudiante in listaEstudiantes)
            {
                // Crear una fila con los valores de las propiedades del estudiante
                DataRow fila = tablaAsistencia.NewRow();
                fila["COD"] = estudiante.Codigo;
                fila["NOMBRE"] = estudiante.Nombre;
                fila["CAR"] = estudiante.Carrera;
                // Recorrer el arreglo de asistencia del estudiante, y asignar un valor a cada columna de la fila
                for (int i = 0; i < 31; i++)
                {
                    // Si el estudiante asistió ese día, asignar "A", sino asignar "F"
                    fila[i + 3] = estudiante.Asistencia[i] ? "A" : "F";
                }
                // Agregar la fila a la tabla
                tablaAsistencia.Rows.Add(fila);
            }

            // Mostrar la tabla en la consola, usando el método WriteXml
            tablaAsistencia.WriteXml(Console.Out);

            // Mostrar la tabla en un formulario, usando el control DataGridView
            // Crear un formulario
            System.Windows.Forms.Form formulario = new System.Windows.Forms.Form();
            // Crear un control DataGridView
            System.Windows.Forms.DataGridView vista = new System.Windows.Forms.DataGridView();
            // Asignar la tabla como origen de datos del control
            vista.DataSource = tablaAsistencia;
            // Ajustar el tamaño de las columnas al contenido
            vista.AutoResizeColumns();
            // Añadir el control al formulario
            formulario.Controls.Add(vista);
            // Mostrar el formulario
            formulario.ShowDialog();
        }

        // Método auxiliar para generar un arreglo de asistencia aleatorio
        static bool[] GenerarAsistencia()
        {
            // Crear un arreglo de 31 elementos
            bool[] asistencia = new bool[31];
            // Crear un objeto Random para generar números aleatorios
            Random random = new Random();
            // Recorrer el arreglo y asignar un valor aleatorio entre 0 y 1
            for (int i = 0; i < 31; i++)
            {
                asistencia[i] = random.Next(0, 2) == 1;
            }
            // Devolver el arreglo
            return asistencia;
        }
    }
}