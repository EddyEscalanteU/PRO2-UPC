﻿namespace Practica2{
    class Program{
        public static void Main(string[] args)
        {
         

            Estudiante myMascota =  new Estudiante();
            Console.WriteLine(myMascota.Mostrar());

            
            Inscrito myInscrito =  new Inscrito();
            Console.WriteLine(myInscrito.Mostrar());

            Materia myMateria =  new Materia();
            Console.WriteLine(myMateria.Mostrar());
            

        
        }
    
    }
}