int num;

try
{
    Console.WriteLine("Ingrese el numero: ");
    num=Convert.ToInt32(Console.ReadLine());

    if (num%2==0){
        Console.WriteLine("El numero es PAR.");
    }else{
        Console.WriteLine("EL numero es IMPAR.");
    }
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}