namespace Practica2{
    class Programa{
        public static void Main (string[] args)
        {
            mascota mascota1 = new mascota();
            Console.WriteLine(mascota1.nombre);
            mascota1.DarNombre("Firulais");
            Console.WriteLine(mascota1.nombre);
        

        }
    }
}