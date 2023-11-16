using System; // Para ahorrar escribir System.Console.WriteLine ;)
class MainClass {
  public static void Main (string[] args) {
		// Nuestro arreglo
		double[] calificaciones = {90, 98, 85, 95, 90, 80, 70, 100, 55};
		// Vamos a almacenar la sumatoria
		double sumatoria = 0;
		// Lo recorremos con un foreach
		foreach(double calificacion in calificaciones){
			// Ir agregando la calificación a la sumatoria
			sumatoria += calificacion;
		}
		// El promedio resulta de dividir la sumatoria entre la cantidad de elementos
		double promedio = sumatoria / calificaciones.Length;
    Console.WriteLine("Promedio: " + promedio);
  }
}