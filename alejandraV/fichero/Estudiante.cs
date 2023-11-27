namespace MyNamespace
{
    public class Estudiante
    {
        // Atributos privados
        private string carnet;
        private string codigoEstudiante;
        private string nombre;
        private string apellidoPaterno;
        private string apellidoMaterno;
        private int edad;

        // Procedimiento
        public string GetCarnet()
        {
            return carnet;
        }

        public void SetCarnet(string value)
        {
            carnet = value;
        }

        public string GetCodigoEstudiante()
        {
            return codigoEstudiante;
        }

        public void SetCodigoEstudiante(string value)
        {
            codigoEstudiante = value;
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
    }
}
