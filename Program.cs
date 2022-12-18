// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

int num, x, sum, Starting, Ending;

Console.WriteLine("Please Enter The Primer Number");

Console.WriteLine("Start");
Starting = int.Parse(Console.ReadLine());

Console.WriteLine("End");
Ending = int.Parse(Console.ReadLine());

for (num = Starting; num<= Ending; num++)
{
    sum = 0;

    for (x = 2; x <= num / 2 ; x++ )
    {
       if (num % x ==0)
            {
                sum++;
                break;
            }
    }
    if (sum == 0 && num != 1)
        Console.WriteLine("{0}", num);
}
Console.WriteLine("Ending Process");
Console.ReadKey();
