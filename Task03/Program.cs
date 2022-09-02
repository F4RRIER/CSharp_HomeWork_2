System.Console.WriteLine("Введите цифру, обозначающую день недели");
int DayNum = int.Parse(Console.ReadLine());

void WeekDay (int DayNum) 
{
    if (DayNum == 6 || DayNum == 7) 
        {
            System.Console.WriteLine("Это выходной день");
        }
    else if (DayNum < 1 || DayNum > 7) 
        {
            System.Console.WriteLine("Введите число от 1 до 7");
        }
    else System.Console.WriteLine("Это рабочий день");
}
WeekDay(DayNum);