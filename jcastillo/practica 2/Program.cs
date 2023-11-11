namespace practica2
{
    class program
    {
        static void Main(String[] args)
        {
           Mascota mascota1 = new Mascota();
            Console.WriteLine(mascota1.Mostrar());
            mascota1.DarNombre("firulais");
            Console.WriteLine(mascota1.Mostrar());

            Persona varibleJuan = new Persona();
            Console.WriteLine(varibleJuan.Mostrar());
            Persona pedro = new Persona(123, "El Pedro", 10);
            Console.WriteLine(pedro.Mostrar());
            */

             Mascota myMascota =  new Mascota();
            Console.WriteLine(myMascota.Mostrar());
        }
    }
}