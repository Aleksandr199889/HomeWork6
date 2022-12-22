// Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
// Результат сложения вывести на экран.
// 1, 3, 8, 3, 2 -> 11
// 8, 3, 4, 2 -> 28

Console.Write("Введите число, ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

for(int i = 0; i < size; i++)
{
    numbers[i] =  new Random().Next(1, 11);
}


void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int product = 0;
int sum = 0;
for( int i = 0, j = size-1; i < size/2; i++, j--)
{
    product = numbers[j] * numbers[i];
    sum = sum + product;
}

PrintArray( numbers);
Console.Write(sum);