namespace ProgramacionDos{
    public class Program{
        public static void Main(string[] args)
        {
            Estudiante e1 =new Estudiante(5412367,54123670, "Jennifer", "Morales", "Saucedo", 18);
            Estudiante e2 =new Estudiante(12654783,126547835, "Marilin", "Avila", "Carrasco", 21);
            e1.Mostrar();
            e2.Mostrar();
        }
    }
}
