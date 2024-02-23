String numero;

Console.WriteLine("Ingrese el numero en letras (1-5): ");
numero=Console.ReadLine().ToLower();

switch (numero)
{
    case "uno":
        Console.WriteLine("1");
        break;

    case "dos":
        Console.WriteLine("2");
        break;

    case "tres":
        Console.WriteLine("3");
        break;

    case "cuatro":
        Console.WriteLine("4");
        break;

    case "cinco":
        Console.WriteLine("5");
        break;

    default:
        Console.WriteLine("El numero ingresado esta fuera del rango especificado.");
        break;
}