int[] puntajes = new int[6];
int max = 0, mayores500 = 0;

for (int i = 0; i < 6; i++) {
    Console.Write("Puntaje " + (i+1) + ": ");
    puntajes[i] = int.Parse(Console.ReadLine());
    if (i == 0) max = puntajes[i]; // primera vez
    if (puntajes[i] > max) max = puntajes[i];
    if (puntajes[i] > 500) mayores500++;
}

Array.Sort(puntajes);

Console.WriteLine("Mayor: " + max);
Console.WriteLine("Ordenados:");
for (int i = 0; i < 6; i++) Console.WriteLine(puntajes[i]);
Console.WriteLine("Mayores a 500: " + mayores500);
