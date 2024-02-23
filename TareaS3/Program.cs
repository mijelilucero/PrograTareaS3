String dia;
int numero=0;

Console.WriteLine("Ingrese un numero (1-7): ");
numero=Convert.ToInt32(Console.ReadLine());

switch (numero)
{
    case 1:
        dia = "lunes";
        break;

    case 2:
        dia = "martes";
        break;

    case 3:
        dia = "miercoles";
        break;

    case 4:
        dia = "jueves";
        break;

    case 5:
        dia = "viernes";
        break;

    case 6:
        dia = "sabado";
        break;

    case 7:
        dia = "domingo";
        break;

    default:
        Console.WriteLine("El numero ingresado esta fuera del rango especificado.");
        dia = "ninguno";
        break;
}

Console.WriteLine("El dia correspondiente al numero ingresado es: " + dia);