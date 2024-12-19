// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

string[] schedule = new string[5];
schedule[0] = "Sunday";
schedule[1] = "Monday";
schedule[2] = "Tuesday";
schedule[3] = "Wedensday";
schedule[4] = "Thursday";
for (int x = 0; x < schedule.Length; x++)
{
    Console.WriteLine(schedule[x]);
}

int[] numbers = new int[5];
numbers[0] = 2;
numbers[1] = 3;
numbers[2] = 4;
numbers[3] = 5;
numbers[4] = 6;
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum+= numbers[i];
   
}
Console.WriteLine(sum);
