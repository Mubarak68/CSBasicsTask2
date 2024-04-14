// See https://aka.ms/new-console-template for more information

//Task 3 C# Control Flow
//Challenge 1
Console.WriteLine("-------------<3>-------------");
int currentHour = DateTime.Now.Hour;
if (currentHour >= 11 && currentHour <= 14)
{
    Console.WriteLine("Time for Lunch!!!");
}
else
{
    Console.WriteLine("Sorry lunch time has Finished");
}

Console.WriteLine("-------------<3.1>-------------");
//Challenge 2
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-------------<3.2>-------------");
//Bonus

int countDown = 5;

while (countDown > 0)
{
    Console.WriteLine(countDown);
    countDown--;
}


Console.WriteLine("-------------<4>-------------");

//C# Arrays

//Challenge 1
string[] dayOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
//for (int i = 0; i < dayOfWeek.Length; i++)
//{
  //  Console.WriteLine(dayOfWeek[i]);
//}
//or
foreach (var i in dayOfWeek)
{
    Console.WriteLine(i);
}

int[] array = { 23, 213, 312, 32, 4, 355, 45, 64, 6 };
var sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
    Console.WriteLine(sum);
}
//Bonus
int[,] numbering = { { 12, 22, 1 }, { 21, 554, 33 } };
Console.WriteLine(numbering[0, 12]);