namespace actividad5{
    class Program{
        public static void Main(string[] args){
          Asistencia asistencia1 = new Asistencia();
          Console.WriteLine(asistencia1.Nombre);  
         
          Materia materia1 = new Materia();
          Console.WriteLine(materia1.Mostrar());         
        }
    }
}