Decimal precio, descuento=0.10m, preciofin;

try
{
    Console.WriteLine("Ingrese el precio original del producto: ");
    precio = Convert.ToDecimal(Console.ReadLine());

    if (precio>100){
        preciofin = precio - (precio * descuento);

        Console.WriteLine("El precio final es de: " + preciofin);
    }else{
        Console.WriteLine("El producto no aplica para descuento.");
    }
}
catch(Exception error)
{
    Console.WriteLine("Ha ocurrido un error: " + error.Message);
}