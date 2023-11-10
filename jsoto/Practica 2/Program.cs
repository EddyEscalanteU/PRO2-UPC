namespace Practica2
{
    class Program 
    {
       public static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota();
            Console.WriteLine(mascota1.nombre);
            mascota1.DarNombre("Firulais");
            Console.WriteLine(mascota1.nombre);



        }   

    }



}