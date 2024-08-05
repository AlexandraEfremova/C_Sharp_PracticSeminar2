// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X != 0 и Y != 0 и выдаёт
// номер координатной четверти плоскости, в которой находится эта точка

System.Console.WriteLine("Введите координату X. Она НЕ должна быть равна 0");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y. Она НЕ должна быть равна 0");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

if(xCoordinate != 0 && yCoordinate != 0)
{
    if(xCoordinate >  0)
    {
        if(yCoordinate > 0)
        {
            System.Console.WriteLine($"Координатная точка координат: {xCoordinate} и {yCoordinate} находится в 1 четверти координатной плоскости");
        }
        else
        {
            System.Console.WriteLine($"Координатная точка координат: {xCoordinate} и {yCoordinate} находится в 4 четверти координатной плоскости");

        }
    }
    else
    {
        if(yCoordinate > 0)
        {
            System.Console.WriteLine($"Координатная точка координат: {xCoordinate} и {yCoordinate} находится во 2 четверти координатной плоскости");
        }
        else
        {
            System.Console.WriteLine($"Координатная точка координат: {xCoordinate} и {yCoordinate} находится в 3 четверти координатной плоскости");

        }
    }
}
else
{
    if(xCoordinate == 0)
    {
        System.Console.WriteLine("Вы ввели занчение 0 на X координату. Прочитайте условие. Попробуйте ещё раз");
    }
    else
    {
        System.Console.WriteLine("Вы ввели занчение 0 на Y координату. Прочитайте условие. Попробуйте ещё раз");
    }

}
