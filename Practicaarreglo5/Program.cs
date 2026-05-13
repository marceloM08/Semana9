double[] notas = new double[8];
double suma = 0; int reprobados = 0;

for (int i = 0; i < 8; i++) {
    Console.Write("Nota " + (i+1) + ": ");
    notas[i] = double.Parse(Console.ReadLine());
    suma += notas[i];
    if (notas[i] < 60) reprobados++;
}

Console.WriteLine("Notas aprobadas:");
for (int i = 0; i < 8; i++) if (notas[i] >= 60) Console.WriteLine(notas[i]);
Console.WriteLine("Reprobados: " + reprobados);
Console.WriteLine("Promedio: " + (suma/8));
