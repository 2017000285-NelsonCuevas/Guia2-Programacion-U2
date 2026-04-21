internal class Program
{
    private static void Main(string[] args)
    {
        Double grados, radianes, resultado;
        int opc;
        Console.WriteLine("Ingrese el angulo en grados: ");
        grados = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("LISTA DE FUNCIONES TRIGONOMETRICAS");
        Console.WriteLine("1 = SENO");
        Console.WriteLine("2 = COSENO");
        Console.WriteLine("3 = TANGENTE");

        Console.WriteLine("Elija una opcion: ");
        opc = Convert.ToInt32(Console.ReadLine());

        radianes = grados * (Math.PI / 180);
        switch (opc)
        {
            case 1:
                resultado = Math.Sin(radianes);
                Console.WriteLine($"El Seno de {grados}° es de: {resultado}");
                break;
            case 2:
                resultado = Math.Cos(radianes);
                Console.WriteLine($"El Coseno de {grados}° es de: {resultado}");
                break;
            case 3:
                resultado = Math.Tan(radianes);
                Console.WriteLine($"La Tangente de {grados}° es de: {resultado}");
                break;
            default:
                Console.WriteLine("OPCION NO VALIDA");
                break;
        }
    }
}