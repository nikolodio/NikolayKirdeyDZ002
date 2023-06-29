Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
if (stringNumber.Length > 2)
{
    Console.WriteLine("three digit -> " + stringNumber[2]);
}
else
{
    Console.WriteLine("-> no third digit");
}