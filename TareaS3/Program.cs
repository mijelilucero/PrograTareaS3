int edad;

try
{
    Console.WriteLine("Ingrese su edad: ");
   edad = Convert.ToInt32(Console.ReadLine());

    if (edad>=18){
        Console.WriteLine("Edad adecuada. Ingreso al club permitido.");
    }else{
        Console.WriteLine("No alcanza la edad mínima requerida. Ingreso al club NO permitido.");
    }
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}