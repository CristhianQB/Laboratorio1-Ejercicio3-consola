using System;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

Console.WriteLine("Nota de los parciales");
Console.Write("Parcial 1:  ");
int parl1 = int.Parse(Console.ReadLine());
Console.Write("Parcial 2:  ");
int parl2 = int.Parse(Console.ReadLine());
Console.Write("Parcial 3:  ");
int parl3 = int.Parse(Console.ReadLine());

Console.WriteLine("Nota del examen final");
int final = int.Parse(Console.ReadLine());

Console.WriteLine("Nota del trabajo final");
int trb = int.Parse(Console.ReadLine());

double notafinal = 0.55 * (parl1 + parl2 + parl3) / 3 + 0.30 * final + 0.15 * trb;

Console.WriteLine("Su promedio es: "+notafinal);   