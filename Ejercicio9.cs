internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("EMPRESA T&S, S.A de C.A");
        double PSinIva = 650;
        double PConIva = PSinIva * 1.12;
        int impresoras, opcionPago;
        double descuento = 0, subtotal, total;
        string FormaPago = "";

        Console.WriteLine("Escriba la cantidad de impresoras que desee comprar: ");
        impresoras = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Elija la forma de pago: ");
        opcionPago = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1 - Efectivo (10% descuento)");
        Console.WriteLine("2 - Tarjeta de Crédito (5% descuento)");
        Console.WriteLine("3 - Vale de regalo (15% descuento)");

        subtotal = PConIva * impresoras;
        switch (opcionPago)
        {
            case 1:
                descuento = subtotal * 0.10;
                FormaPago = "EFECTIVO";
                Console.WriteLine("Forma de Pago: EFECTIVO");
                break;
            case 2:
                descuento = subtotal * 0.05;
                FormaPago = "TARJETA DE CREDITO";
                Console.WriteLine("Forma de Pago: TARJETA DE CREDITO");
                break;
            case 3:
                descuento = subtotal * 0.15;
                FormaPago = "VALE DE REGALO";
                Console.WriteLine("Forma de Pago: VALE DE REGALO");
                break;
            default:
                FormaPago = "NO VALIDO";
                Console.WriteLine("FORMA DE PAGO NO VALIDA!!!");
                break;
        }
        total = subtotal - descuento;
        Console.WriteLine("===DETALLES===");
        Console.WriteLine($"Cantidad de Impresoras compradas: {impresoras}");
        Console.WriteLine($"El precio unitario de la impresora (con IVA): Q.{PConIva:F2} ");
        Console.WriteLine($"El total sin descuento: Q.{subtotal:F2} ");
        Console.WriteLine($"La forma de pago: {FormaPago}");
        Console.WriteLine($"El descuento realizado: Q.{descuento:F2} ");
        Console.WriteLine($"El total a pagar Considere que todos los descuentos se realizan sobre el precio CON IVA: Q.{total:F2} ");
    }
}