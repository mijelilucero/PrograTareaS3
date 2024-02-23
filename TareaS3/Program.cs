int num1, num2, num3, mayor;

try
{
    Console.WriteLine("Ingrese el primer número: ");
    num1=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número: ");
    num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese el tercer número: ");
    num3 = Convert.ToInt32(Console.ReadLine());

    if (num1 == num2 && num2 == num3){
        mayor = num1;
        Console.WriteLine("Los tres números son iguales");
    }else if (num1 > num2&& num1>num3){
        mayor = num1;
    }else if (num1 < num2 && num2 >= num3){
        mayor = num2;
    }else{
        mayor = num3;
    }

    Console.WriteLine("El numero mayor es: "+mayor);
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}