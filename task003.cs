Console.WriteLine("Enter the day of the week");
int dayNumber = Convert.ToInt32(Console.ReadLine());
int[] array = { 1, 2, 3, 4, 5, 6, 7 };
if (dayNumber <= 5)
{
    Console.WriteLine($"{dayNumber} -> no, this day is nit holiday");
}
else
{
    Console.WriteLine($"{dayNumber} -> yes, this day is holiday ");
}