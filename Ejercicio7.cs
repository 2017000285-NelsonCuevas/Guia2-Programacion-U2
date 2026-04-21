internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===CONVERSOR DE MEDIDAS===");
        Console.WriteLine("A = METROS");
        Console.WriteLine("B = PIES");
        Console.WriteLine("C = CENTIMETROS");
        Console.WriteLine("D = PULGADAS");
        int opc;
        Console.WriteLine("Escriba un valor: ");
        opc = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elija una medida de conversion: ");
        char medidas = Convert.ToChar(Console.ReadLine().ToUpper());
        double resultado;

        switch (medidas)
        {
            case 'A':
                resultado = opc;
                Console.WriteLine($"Metros: {resultado} metros");
                break;
            case 'B':
                resultado = opc * 3.28084;
                Console.WriteLine($"Metros: {resultado} pies");
                break;
            case 'C':
                resultado = opc * 100;
                Console.WriteLine($"Metros: {resultado} centimetros");
                break;
            case 'D':
                resultado = opc * 39.3701;
                Console.WriteLine($"Metros: {resultado} pulgadas");
                break;
            default:
                Console.WriteLine("ERROR, DIGITE UNA CONVERSION CORRECTA");
                break;
        }
    }
}