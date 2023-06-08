void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(1,100);
}
}

void PrintArray(int[] array)
{
foreach (var item in array)
{
Console.Write($"{item} ");
}
System.Console.WriteLine();
}

void Even(int[] array)
{
   int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (i % 2 != 0)
    sum = sum + array[i];
}
System.Console.WriteLine($"Сумма нечетных элементов = {sum}");
}

//Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);
Even(array);