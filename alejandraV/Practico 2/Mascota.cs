namespace HelloWorld {
    public class Mascota{
        public string Nombre;
        public int Edad;
        public string NombrePropietario;

        //public Persona propietario;

        public string Color;
        public string Categoria;
        public Mascota(){
            Nombre = " ";
            Edad = 0;
            NombrePropietario = " ";
           // propietario = new Persona();
            Color = " ";
            Categoria = " ";

        }
        public void DarNombre(string valor){
            Nombre = valor;
        }
        public void DarNombrePropietario(string valor){
            NombrePropietario = valor;
            
           // propietario = valor

        }
        public void DarEdad(int valor){
            Edad = valor;
        }
        public void AsignarColor(string valor){
            Color = valor;
        }
        public void AsignarCategoria(string valor){
            Categoria = valor;
        }

        public string Mostrar(){
            return
            "Nombre: " + Nombre + "Edad: "+ " " + Edad + "NombrePropietario"+ NombrePropietario + " " + "Color: " + Color + " "+ "Categoria" + Categoria;
        }


    }
}