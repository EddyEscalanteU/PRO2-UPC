namespace MyNamespace{

    public class program{

        public static void Main(string[] arg)
        {

            ClaseArray A = new ClaseArray(4);
            A.ArrayCadena[0] = "Ereli";
            A.ArrayCadena[1] = "Maria";
            A.ArrayCadena[2] = "Ines";
            A.ArrayCadena[3] = "Joel";
            A.mostrarArray();

             ClaseArray B = new ClaseArray(5);
            B.ArrayCadena[0] = "Douglas";
            B.ArrayCadena[1] = "Maria";
            B.ArrayCadena[2] = "Ines";
            B.ArrayCadena[3] = "Joel";
            B.mostrarArray();
        }
    
    }
}

    