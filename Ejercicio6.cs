internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===ESTADIO DOROTEO GUAMUCH FLORES===");
        Console.WriteLine("1 = Palco: Q300.00");
        Console.WriteLine("2 = Tribuna: Q100.00 - Q125.00");
        Console.WriteLine("3 = Preferencia: Q50.00 - Q75.00");
        Console.WriteLine("4 = Generales: Q30.00 - Q50.00");
        int sector, entradas;
        double total;
        Console.WriteLine("Escribe en que sector deseas ver el partido: ");
        sector = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Escribe cuantas entradas quieres para ver el partido: ");
        entradas = Convert.ToInt32(Console.ReadLine());

        switch (sector)
        {
            case 1:
                total = 300 * entradas;
                Console.WriteLine($"Total para Palco seria: Q.{total}");
                break;
            case 2:
                total = 125 * entradas;
                Console.WriteLine($"Total para Tribuna seria: Q.{total}");
                break;
            case 3:
                total = 75 * entradas;
                Console.WriteLine($"Total para Preferencia seria: Q.{total}");
                break;
            case 4:
                total = 50 * entradas;
                Console.WriteLine($"Total para General seria: Q.{total}");
                break;
            default:
                Console.WriteLine("ERROR, ESCRIBA UN SECTOR VALIDO");
                break;
        }
    }
}