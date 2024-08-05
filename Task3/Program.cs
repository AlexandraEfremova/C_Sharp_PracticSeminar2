// Напишите программу, которая принимает на вход 
// целое число из отрезка [10, 99] и показывает наибольшую цифру числа

System.Console.WriteLine("Введите число от 10 до 99");
int userNumber = Convert.ToInt32(Console.ReadLine());

int firstNum = userNumber / 10;
int secondNum = userNumber % 10;

if(userNumber >= 10 && userNumber <= 99)
{
    if(firstNum > secondNum)
    {
        System.Console.WriteLine($"В числе {userNumber} больше первая цифра: {firstNum}");
    }
    else
    {
        System.Console.WriteLine($"В числе {userNumber} больше вторая цифра: {secondNum}");
    }
}
else
{
    System.Console.WriteLine($"Заданное Вами число: {userNumber} не подходит под условие.\n Прочтите условие. Попробуйте ещё раз");
}
