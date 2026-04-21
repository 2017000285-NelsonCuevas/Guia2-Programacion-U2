internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===Dias de la semana===");
        int d;

        Console.WriteLine("Digite el numero del dia de la semana: ");
        d = Convert.ToInt32(Console.ReadLine());

        switch (d)
        {
            case 1:
                Console.WriteLine("Es Lunes");
                break;
            case 2:
                Console.WriteLine("Es Martes");
                break;
            case 3:
                Console.WriteLine("Es Miercoles");
                break;
            case 4:
                Console.WriteLine("Es Jueves");
                break;
            case 5:
                Console.WriteLine("Es Viernes");
                break;
            case 6:
                Console.WriteLine("Es Sabado");
                break;
            case 7:
                Console.WriteLine("Es Domingo");
                break;
            default:
                Console.WriteLine("Coloque un numero valido");
                break;
        }
    }
}