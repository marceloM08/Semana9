double[] ventas = new double[7];
double total = 0; int dias150 = 0; double min = 0;

for (int i = 0; i < 7; i++) {
    Console.Write("Ventas día " + (i+1) + ": ");
    ventas[i] = double.Parse(Console.ReadLine());
    total += ventas[i];
    if (i == 0) min = ventas[i];
    if (ventas[i] > 150) dias150++;
    if (ventas[i] < min) min = ventas[i];
}

Console.WriteLine("Total: " + total);
Console.WriteLine("Días >150: " + dias150);
Console.WriteLine("Venta más baja: " + min);
