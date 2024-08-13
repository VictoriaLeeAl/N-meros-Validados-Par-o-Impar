using System;

int N;
int num;
int pares=0;
int impares = 0;
float mod; 
Console.Write("¿Cuántos números serán? ");
N = Int32.Parse(Console.ReadLine());

for (int i=1; i<=N; i++)
{
    Console.Write("Valor del número " + i + ": ");
    num = Int32.Parse(Console.ReadLine());
    mod = num % 2;
    if (mod == 0)
    {
        Console.WriteLine("El número " + num +  " es par ");
        pares = pares + 1;
    }
    else
    {
        Console.WriteLine("El número " + num +  " es impar ");
        impares = impares + 1;
    }
}

Console.WriteLine("");
Console.WriteLine("La cantidad de números pares es " + pares);
Console.WriteLine("La cantidad de números impares es " + impares);

