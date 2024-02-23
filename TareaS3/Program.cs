String usuario, contrasena;

try
{
    Console.WriteLine("Ingrese el nombre de usuario: ");
    usuario=Console.ReadLine();

    Console.WriteLine("Ingrese la contrasena: ");
    contrasena=Console.ReadLine();

    if (usuario=="usuario" && contrasena=="contraseña"){
        Console.WriteLine("Credenciales correctas. Acceso permitido.");
    }else{
        Console.WriteLine("Usuario o contraseña incorrectos.");
    }
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}