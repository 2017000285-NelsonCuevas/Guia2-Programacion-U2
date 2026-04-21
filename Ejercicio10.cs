internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===MESES DEL AÑO===");
        int mes;
        Console.WriteLine("Ingresa un numero del 1 al 12: ");
        mes = Convert.ToInt32(Console.ReadLine());

        switch (mes)
        {
            case 1:
                Console.WriteLine("ENERO y tiene 31 dias");
                break;
            case 2:
                Console.WriteLine("FEBRERO y tiene 28 dias (29 si es año bisiesto)");
                break;
            case 3:
                Console.WriteLine("MARZO y tiene 31 dias");
                break;
            case 4:
                Console.WriteLine("ABRIL y tiene 30 dias");
                break;
            case 5:
                Console.WriteLine("MAYO y tiene 31 dias");
                break;
            case 6:
                Console.WriteLine("JUNIO y tiene 30 dias");
                break;
            case 7:
                Console.WriteLine("JULIO y tiene 31 dias");
                break;
            case 8:
                Console.WriteLine("AGOSTO y tiene 31 dias");
                break;
            case 9:
                Console.WriteLine("SEPTIEMBRE  y tiene 30 dias");
                break;
            case 10:
                Console.WriteLine("OCTUBRE y tiene 31 dias");
                break;
            case 11:
                Console.WriteLine("NOVIEMBRE y tiene 30 dias");
                break;
            case 12:
                Console.WriteLine("DICIEMBRE y tiene 31 dias");
                break;
            default:
                Console.WriteLine("ERROR DIGITE UN NUMERO CORRECTO");
                break;
        }
    }
}