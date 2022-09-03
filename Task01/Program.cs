System.Console.WriteLine("Введите трёхзначное число: ");
int threeNumber = int.Parse(Console.ReadLine());
string stringNumber = Convert.ToString(threeNumber);
System.Console.WriteLine("Вторая цифра этого числа: " + stringNumber[1]);