<<<<<<< HEAD
﻿double[] temperaturas = new double[7];
double suma = 0;

Console.Write("Ingrese la temperatura del día 1: ");
temperaturas[0] = double.Parse(Console.ReadLine());
double max = temperaturas[0];
double min = temperaturas[0];
suma += temperaturas[0];

for (int i = 1; i < 7; i++) {
    Console.Write("Ingrese la temperatura del día " + (i+1) + ": ");
    temperaturas[i] = double.Parse(Console.ReadLine());
    suma += temperaturas[i];
    if (temperaturas[i] > max) max = temperaturas[i];
    if (temperaturas[i] < min) min = temperaturas[i];
}

Console.WriteLine("\nTemperaturas registradas:");
for (int i = 0; i < 7; i++) {
    Console.WriteLine(temperaturas[i]);
}

Console.WriteLine("Promedio semanal: " + (suma/7));
Console.WriteLine("Temperatura más alta: " + max);
Console.WriteLine("Temperatura más baja: " + min);
=======
﻿
>>>>>>> 3b1c935fd87467e8277587a074ff6f51c6e78d6f
