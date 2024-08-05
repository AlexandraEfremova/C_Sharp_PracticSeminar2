// Напишите программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую.

System.Console.WriteLine("Введите любое натуральное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = 0;
while (userNumber > 0)
{
    number = userNumber % 10;
    System.Console.Write($"{number}, ");
    userNumber = userNumber / 10;
}