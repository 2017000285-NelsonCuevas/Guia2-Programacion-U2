internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CLASIFICACION DE LETRAS POR RANGO");
        char letra = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (letra)
        {
            case 'A':
                Console.WriteLine("EXCELENTE");
                break;
            case 'B':
                Console.WriteLine("BUENO");
                break;
            case 'C':
                Console.WriteLine("REGULAR");
                break;
            case 'D':
                Console.WriteLine("DEFICIENTE");
                break;
            case 'F':
                Console.WriteLine("REPROBADO");
                break;
            default:
                Console.WriteLine("LETRA NO VALIDA!!!!");
                break;
        }


    }
}