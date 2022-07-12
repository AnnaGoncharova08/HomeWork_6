// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Zadacha41()
{
Console.WriteLine("Сколько чисел будет введено: ");
string number = Console.ReadLine();
Console.WriteLine("Введите числа: ");
string numbers = Console.ReadLine();
Positive (numbers);

void Positive (string numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count += 1;
        }
    }
    Console.WriteLine(count);
}
}
Zadacha41();