// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Zadacha41()
{
Console.WriteLine("Введите необходимое количество чисел: ");
int m = 3;
int count = 0;
for (int i = 1; i <= m; i++)
    {
        Console.WriteLine();
        Console.Write($" Введите {i}-е число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }
    Console.Write($"Количество чисел больше нуля:" + count);
    Console.WriteLine();
}
Zadacha41();