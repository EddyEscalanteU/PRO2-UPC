namespace Fichero{
    public class Program{
        public static void Main(string[] args){
            /*Estudiante el = new Estudiante(123, 456, "douglas", "AppP", "AppM", 19);
            Estudiante e2= new Estudiante(123, 456, "locos", "como", "quispe", 20);
            el.Mostrar();
            e2.Mostrar();
            /////// un comentario
            string path = "C:/Users/USUARIO/Documents/GitHub/PRO2-UPC/dfernandez/Fichero/archivo.txt";
            Ficherodouglas f = new Ficherodouglas(path);
            //string texto = f.ReadAllText(path);
            //Console.WritelLine(texto);

            //f.ReadAllLines(path);

            Estudiante e1 = new Estudiante(9775810, 12345678, 
            "Adrian Douglas", "Fernandez", "Matos", 19);

            Estudiante e2 = new Estudiante(14274252, 14274252, 
            "Bryan", "Carrasco", "Cruz", 19);

            string[] student1 = e1.EstudianteToArray();
            string[] student2 = e2.EstudianteToArray();
  
            string path1 = "C:/Users/USUARIO/Documents/GitHub/PRO2-UPC/dfernandez/Fichero/" + e1.GetNombre() + ".txt";
            string path2 = "C:/Users/USUARIO/Documents/GitHub/PRO2-UPC/dfernandez/Fichero/" + e2.GetNombre() + ".txt";
            f.WriteLine(path1, student1);
            f.WriteLine(path2, student2);

            string[] estudianteFichero = f.ReadAllLinesV2(path1);
            Estudiante e3 = new Estudiante();
            e3.ArrayToEstudiante(estudianteFichero);
            e3.Mostrar();
*/
            //42,9kb
            DateTime timeInicio = DateTime.Now;
            Console.WriteLine("Inicio; " + timeInicio);
            Ficherodouglas f = new Ficherodouglas ();
            for(int i = 1; i<=20000;i++){
                Estudiante e = new Estudiante(9775810, 12345678,
                "Adrian Douglas", "Carrasco", "Cruz", 19);
                string[] arrayEstudiante = e.EstudianteToArray();
                string pathFor = "C:/Users/USUARIO/Documents/GitHub/PRO2-UPC/dfernandez/Fichero/ficherofor/" + i;
                f.WriteLine(pathFor, arrayEstudiante);

            }
            DateTime timeFin = DateTime.Now;
            Console.WriteLine("Fin: " + timeFin);
            Console.WriteLine("Total: " + timeFin.Subtract(timeInicio));


        }
        
    }
}
