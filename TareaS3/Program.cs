double calificacion;

Console.WriteLine("Ingrese su calificación: ");
calificacion=Convert.ToDouble(Console.ReadLine());

if (calificacion == Math.Floor(calificacion))
{
 
    switch (calificacion)
    {
        case double i when (i >= 95 && i <= 100):
            Console.WriteLine("Has alcanzado una calificacion excepcional y eres elegible para recibir un reconocimiento.");
            break;

        case double i when (i >= 86 && i <= 94):
            Console.WriteLine("Has obtenido una calificacion sobresaliente en tu examen.");
            break;

        case double i when (i >= 71 && i <= 85):
            Console.WriteLine("Has aprobado el examen con una calificacion destacada.");
            break;

        case double i when (i >= 62 && i <= 70):
            Console.WriteLine("Has alcanzado la nota suficiente para ser promovido al siguiente curso.");
            break;

        case double i when (i == 61):
            Console.WriteLine("Has obtenido la calificación minima para aprobar el examen.");
            break;

        case double i when (i > 0 && i <= 60):
            Console.WriteLine("Lamentablemente no has alcanzado la calificacion minima para aprobar el examen.");
            break;

        default:
            Console.WriteLine("La calificacion ingresada no es valida.");
            break;
    }
}
else
{
    Console.WriteLine("La calificacion ingresada no es un entero.");
}