/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int inputInt ()
{
Console.WriteLine("Введите число: ");
bool isNum = int.TryParse(Console.ReadLine(), out int num);
if (isNum)
{
    return num;
}
else
{
    Console.WriteLine("Вы ввели некорректные данные!");
    return -1;
}
}

int num = inputInt();

int [] GetTableSq(int num)
{

    int [] arr = new int[num];
    for (int a = 0; a < arr.Length; a++)
    {
        arr[a] = (int)(Math.Pow(a+1, 3));
    }
    return arr;
}

int [] tableSq = GetTableSq(num);

void PrintArray (int [] arr)
{
    for (int a = 0; a < arr.Length; a++)
    {
        Console.WriteLine($"{arr[a]} ");
        
    }
    Console.WriteLine();
}

PrintArray(tableSq);