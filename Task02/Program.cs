System.Console.WriteLine("Введите число: ");
int RandomNum = int.Parse(Console.ReadLine());
string RandomNumText = Convert.ToString(RandomNum);
if (RandomNumText.Length > 2)
{
    Console.WriteLine("Третья цифра: " + RandomNumText[2]);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}