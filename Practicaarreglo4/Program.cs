int[] ventas = new int[5];
int total = 0, max = 0, catMax = 0;

for (int i = 0; i < ventas.Length; i++)
{
    System.Console.Write("Ingrese ventas de la categoría " + (i+1) + ": ");
    ventas[i] = int.Parse(Console.ReadLine()!);
    total += ventas[i];
    if (i == 0) { max = ventas[i]; catMax = 1; }
    if (ventas[i] > max) { max = ventas[i]; catMax = i+1; }
}

System.Console.WriteLine("Total de libros vendidos: " + total);
System.Console.WriteLine("Categoría con más ventas: " + catMax);
System.Console.WriteLine("Promedio de ventas: " + (total/5.0));
