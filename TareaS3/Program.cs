String idioma;

Console.WriteLine("Ingrese el idioma de su preferencia (español/ingles/frances): ");
idioma=Console.ReadLine().ToLower();

switch (idioma)
{
    case "español":
        Console.WriteLine("Hola, ¿Cómo te encuentras hoy?");
        break;

    case "ingles":
        Console.WriteLine("Hello, How are you feeling today?");
        break;

    case "frances":
        Console.WriteLine("Bonjour, Comment vas-tu aujourd'hui ?");
        break;

    default:
        Console.WriteLine("El idioma ingresado no es válido.");
        break;
}