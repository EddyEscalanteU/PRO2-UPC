namespace practica2{
    
      class Program{

         public static void Main (string[] args)
         {
            Mascotas mascota1 = New Mascota();
            Console.WriteLine(mascota1.Nombre);
            mascota1.DarNombre("Sin nombre");
            Console.WriteLine(mascota1.Nombre);
         }
         public string mostrar (){
            return "Nombre: " + Nombre + ", " +
            "Edad: " + Edad + ", " + 
            "Color: " + Nombre + ", " +
            "Edad: " + Edad;
         }
      }
    


}

