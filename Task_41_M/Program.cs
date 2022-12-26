// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int length = int.Parse(Console.ReadLine()!);

int[] array = new int [length];

void GetMassivNum(int[] coll) 
{
    for(int index = 0; index < coll.Length; index ++)
    {
        Console.Write($"Введите {index +1} число: ");
        coll[index] = int.Parse(Console.ReadLine()!);
    }
}

int TheSumNum(int[] coll)
{
    int count = 0;
    for (int index = 0; index < coll.Length; index++)
    {

        if (coll[index] > 0)
        {
            count++; 
        }

    }
    return count;
}

GetMassivNum(array); 
Console.WriteLine(); 
Console.WriteLine(TheSumNum(array)); 