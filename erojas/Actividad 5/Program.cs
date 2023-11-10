using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
          clsEstudiantes estudiantes;
          estudiantes = new clsEstudiantes();
          estudiantes.Grupo = "EA - 12 insc.";
          estudiantes.Materia ="Programacion 2";
          estudiantes.Docente ="Ing. EDDY ESCANTE USTARIZ";
          estudiantes.Periodo = "Noviembre 2023";
          estudiantes.DiasClase = "Lunes a Viernes";
          estudiantes.Horarios = "7 a 10";

          Console.WriteLine("Grupo: "+ estudiantes.Grupo);
          Console.WriteLine("Materia: "+ estudiantes.Materia);
          Console.WriteLine("Docente: "+ estudiantes.Docente);
          Console.WriteLine("Periodo: "+ estudiantes.Periodo);
          Console.WriteLine("Dias de Clase: "+ estudiantes.DiasClase);
          Console.WriteLine("Horarios: "+ estudiantes.Horarios);

          Console.ReadKey();
    

    }
  }
}
