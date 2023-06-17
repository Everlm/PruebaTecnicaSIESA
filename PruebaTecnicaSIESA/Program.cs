using PruebaTecnicaSIESA;

Console.WriteLine("---------MENU---------");
Console.WriteLine("Seleccione una opción:");
Console.WriteLine("1. División de dos números");
Console.WriteLine("2. Arbol");
Console.WriteLine("3. Base");

int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Division();
        break;
    case 2:
        Arbol();
        break;
    case 3:
        Base();
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}


static void Division()
{
    Console.WriteLine("Ingrese el primer número:");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el segundo número:");
    int numero2 = int.Parse(Console.ReadLine());

    try
    {
        Pregunta_17 ask = new Pregunta_17();
        double resultado = ask.Division(numero1, numero2);
        Console.WriteLine("El resultado de la división es: " + resultado);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }

}

static void Arbol()
{
    Pregunta_19 arbol1 = new Pregunta_19(4);

    Pregunta_19 arbol2 = new Pregunta_19(4);
    arbol2.Subarboles.Add(new Pregunta_19(2));
    arbol2.Subarboles.Add(new Pregunta_19(1));

    Pregunta_19 arbol3 = new Pregunta_19(4);
    arbol3.Subarboles.Add(new Pregunta_19(1));
    Pregunta_19 subarbol3 = new Pregunta_19(2);
    subarbol3.Subarboles.Add(new Pregunta_19(3));
    arbol3.Subarboles.Add(subarbol3);
    Pregunta_19 subarbol4 = new Pregunta_19(5);
    subarbol4.Subarboles.Add(new Pregunta_19(1));
    subarbol4.Subarboles.Add(new Pregunta_19(4));
    arbol3.Subarboles.Add(subarbol4);

    ArbolConPeso arbolConPeso1 = new ArbolConPeso(arbol1);
    ArbolConPeso arbolConPeso2 = new ArbolConPeso(arbol2);
    ArbolConPeso arbolConPeso3 = new ArbolConPeso(arbol3);

    Console.WriteLine("Árbol 1 - Peso: " + arbolConPeso1.CalcularPeso());
    Console.WriteLine("Árbol 1 - Peso Promedio: " + arbolConPeso1.CalcularPesoPromedio());
    Console.WriteLine("Árbol 1 - Altura: " + arbolConPeso1.CalcularAltura());

    Console.WriteLine("Árbol 2 - Peso: " + arbolConPeso2.CalcularPeso());
    Console.WriteLine("Árbol 2 - Peso Promedio: " + arbolConPeso2.CalcularPesoPromedio());
    Console.WriteLine("Árbol 2 - Altura: " + arbolConPeso2.CalcularAltura());

    Console.WriteLine("Árbol 3 - Peso: " + arbolConPeso3.CalcularPeso());
    Console.WriteLine("Árbol 3 - Peso Promedio: " + arbolConPeso3.CalcularPesoPromedio());
    Console.WriteLine("Árbol 3 - Altura: " + arbolConPeso3.CalcularAltura());

    Console.ReadLine();
}

static void Base()
{
    Pregunta_18 convertidor = new Pregunta_18();

    Console.WriteLine("Ingrese el número:");
    string numero = Console.ReadLine();

    Console.WriteLine("Ingrese la base de origen:");
    int baseOrigen = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la base de destino:");
    int baseDestino = Convert.ToInt32(Console.ReadLine());

    string resultado = convertidor.ConvertirBase(numero, baseOrigen, baseDestino);

    Console.WriteLine($"El número {numero} en base {baseOrigen} es igual a {resultado} en base {baseDestino}.");
    Console.ReadLine();
}