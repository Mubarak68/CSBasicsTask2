// See https://aka.ms/new-console-template for more information

//Task 3 C# Control Flow
//Challenge 1
int currentHour = DateTime.Now.Hour;
if (currentHour >= 11 && currentHour <= 14)
{
    Console.WriteLine("Time for Lunch!!!");
}
else
{
    Console.WriteLine("Sorry lunch time has Finished");
}

Console.WriteLine("-------------<>-------------");
//Challenge 2
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("-------------<>-------------");
//Bonus

int countDown = 5;

while (countDown > 0)
{
    Console.WriteLine(countDown);
    countDown--;
}
