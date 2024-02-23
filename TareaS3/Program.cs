String servicio;
Decimal pago;

Console.WriteLine("Ingrese el tipo de servicio (lavado de auto/cambio de aceite/revisión mecanica): ");
servicio=Console.ReadLine().ToLower();

switch (servicio)
{
    case "lavado de auto":
        pago=75;
        break;

    case "cambio de aceite":
        pago = 250;
        break;

    case "revision mecanica":
        pago = 500;
        break;

    default:
        Console.WriteLine("El servicio ingresado no esta disponible.");
        pago = 0;
        break;
}

Console.WriteLine("El pago por el servicio de {0} es de: Q.{1}",servicio, pago);