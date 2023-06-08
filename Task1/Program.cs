void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(100,1000);
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
   int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
    count +=1;
}
System.Console.WriteLine($"Четных числел: {count}");
}

Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

FillArray(array);
PrintArray(array);
Even(array);