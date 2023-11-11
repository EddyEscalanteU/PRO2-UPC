namespace Practica2{
    class Program{
        public static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            Console.WriteLine(mascota1.Nombre);
            mascota1.DarNombre("sin nombre");
            Console.WriteLine(mascota1.Nombre);
        }
        public string mostra(){
            return "Nombre: "+ Nombre + ", " +
            "Edad: "+ Edad + ", " +
            "Color: "+ Color + ", " +
            "Edad: "+ edad;

        }
    }
}
