namespace MyNamespaceNamespace
{
    public class Estudiante
    {
        // Atributos privados
        private int carnet;
        private string MicodigoEstudiante;
        private string Minombre;
        private string MiapellidoPaterno;
        private string MiapellidoMaterno;
        private int Miedad;

        // Procedimiento
        public int GetCarnet()
        {
            return carnet;
        }

        public void SetCarnet(int value)
        {
            carnet = value;
        }

        public string GetCodigoEstudiante()
        {
            return MicodigoEstudiante;
        }

        public void SetCodigoEstudiante(string value)
        {
            MicodigoEstudiante = value;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string value)
        {
            nombre = value;
        }

        public string GetApellidoPaterno()
        {
            return apellidoPaterno;
        }

        public void SetApellidoPaterno(string value)
        {
            apellidoPaterno = value;
        }

        public string GetApellidoMaterno()
        {
            return apellidoMaterno;
        }

        public void SetApellidoMaterno(string value)
        {
            apellidoMaterno = value;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int value)
        {
            edad = value;
        }

        public void Mostrar(){

            string resultado = "Estudiante: [/n";
            resultado+= "Carnet= " + GetCarnet() + ";";
            resultado+= "CodigoEstudiante = " + GetCodigoEstudiante() + ";/n";
            resultado+= "Nombre = " + GetNombre() + ";/n";
            resultado+= "ApellidoPaterno = " + GetApellidoPaterno() + ";/n";
            resultado+= "ApellidoPaterno = " + GetApellidoMaterno() + ";/n";
            resultado+= "Edad = " + GetEdad() + ";/n";
            resultado+= "]";

        }


    }
}
