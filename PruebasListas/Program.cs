List<int> numeros = new List<int>();

numeros.Add(10); 
numeros.Add(20); 
numeros.Add(30); 
numeros.Add(40); 
numeros.Add(50);
Console.WriteLine(numeros.Count);

Console.WriteLine(
    "La cantidad de elementos es: "
    + numeros.Count);

string formato = string.Format(
    "La {1} cantidad de elementos es:{0}", numeros.Count, "X");
Console.WriteLine(formato);

string stringInterpolation = 
    $"La {"X"} cantidad de elementos es:{numeros.Count}";

Console.WriteLine(stringInterpolation);

foreach (int numero in numeros) 
{
    Console.WriteLine(numero);
}

Console.WriteLine();
numeros.RemoveAt(0);
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}




Console.WriteLine();
numeros.Remove(40);
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
