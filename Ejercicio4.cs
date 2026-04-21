internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===OPCIONES MATEMATICAS===");
        Console.WriteLine("1. = SUMA");
        Console.WriteLine("2. = RESTA");
        Console.WriteLine("3. = MULTIPLICAR");
        Console.WriteLine("4. = DIVIDIR");
        int num1;
        Console.WriteLine("Ingresa un numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        int num2;
        Console.WriteLine("Ingresa otro numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        int opc;
        Console.WriteLine("Ingresa una opcion del 1 al 4: ");
        opc = Convert.ToInt32(Console.ReadLine());

        switch (opc)
        {
            case 1:
                opc = num1 + num2;
                Console.WriteLine($"SUMA = El resultado es de: {opc}");
                break;
            case 2:
                opc = num1 - num2;
                Console.WriteLine($"RESTA = El resultado es de: {opc}");
                break;
            case 3:
                opc = num1 * num2;
                Console.WriteLine($"MULTIPLICAR = El resultado es de: {opc}");
                break;
            case 4:
                opc = num1 / num2;
                Console.WriteLine($"DIVIDIR = El resultado es de: {opc}");
                break;
            default:
                Console.WriteLine("OPCION INCORRECTA DIGITE UNA CORRECTAAA");
                break;
        }
    }
}