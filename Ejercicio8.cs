internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===MENUUU===");
        Console.WriteLine("1. = HAMBURGUESA");
        Console.WriteLine("2. = PIZZA");
        Console.WriteLine("3. = POLLO FRITO");
        Console.WriteLine("4. = ENSALADA");
        int menu;
        Console.WriteLine("Ingresa un numero para el menu del 1 al 4: ");
        menu = Convert.ToInt32(Console.ReadLine());

        switch (menu)
        {
            case 1:
                Console.WriteLine("HAMBURGUESA");
                break;
            case 2:
                Console.WriteLine("PIZZA");
                break;
            case 3:
                Console.WriteLine("POLLO FRITO");
                break;
            case 4:
                Console.WriteLine("ENSALDA");
                break;
            default:
                Console.WriteLine("INGRESA UN NUMERO ADECUADO PARA ORDENAR");
                break;
        }
    }
}