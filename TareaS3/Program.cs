String figura;
Double bas, altura, lado, radio, area=0;
const double Pi = 3.14159;

try
{
    Console.WriteLine("Ingrese el tipo de figura geomética (triangulo/cuadrado/circulo): ");
    figura=Console.ReadLine().ToLower();

    if (figura=="triangulo"){
        Console.WriteLine("Ingrese la base: ");
        bas = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura: ");
        altura = Convert.ToDouble(Console.ReadLine());

        area = (bas * altura) / 2;
    }else if (figura=="cuadrado"){
        Console.WriteLine("Ingrese el lado: ");
       lado = Convert.ToDouble(Console.ReadLine());

        area = lado*lado;
     }else if (figura == "circulo"){
        Console.WriteLine("Ingrese el radio: ");
        radio = Convert.ToDouble(Console.ReadLine());

        area = Pi*(radio*radio);
    }else{
        Console.WriteLine("Figura geométrica no valida.");
    }

    Console.WriteLine("El area del {0} es de: {1}",figura, area);
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}