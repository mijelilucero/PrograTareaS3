Decimal monto;
int edad;

try
{
    Console.WriteLine("Ingrese el monto del prestamo: ");
    monto=Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Ingrese su edad: ");
    edad = Convert.ToInt32(Console.ReadLine());

    if (monto<5000||edad>60){
        Console.WriteLine("Solicitud de prestamo aprobada.");
    }else{
        Console.WriteLine("Solicitud de prestamo rechazada.");
    }
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}