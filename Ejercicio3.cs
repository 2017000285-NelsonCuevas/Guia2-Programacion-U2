internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un caracter: ");
        char car = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (car)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("El Caracter es una VOCAL");
                break;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("El carácter es un DIGITO");
                break;
            default:
                Console.WriteLine("El carácter no es ni vocal ni dígito");
                Console.WriteLine("INGRESE UNO VALIDO");
                break;
        }
    }
}