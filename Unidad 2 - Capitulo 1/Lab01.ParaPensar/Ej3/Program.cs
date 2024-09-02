
Console.WriteLine("Ingrese la cantidad de iteraciones:");
int max = Convert.ToInt32(Console.ReadLine());
int pri, sec, act;
Console.WriteLine("\nSerie de fibonacci:");

pri = 0;
sec = 1;
for (int i = 0; i < max; i++) 
{
    if (i == 0)
    {   
        Console.WriteLine(0);
    }
    else if (i == 1)
    {
        Console.WriteLine(1);
    }
    else
    {
        act = pri + sec;
        Console.WriteLine(act);
        pri = sec;
        sec = act;
    }
}

