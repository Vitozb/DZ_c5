void FillArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
array[i] = Math.Round(new Random().NextDouble() * 10,2);
}
}

void PrintArray(double[] array)
{
foreach (var item in array)
{
Console.Write($"{item} ");
}
System.Console.WriteLine();
}

void Even(double[] array)
{
   double sum = 0;
   double max = array[0];
   double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i] ) max=array[i];
    if (min > array[i]) min=array[i];
}
sum = max-min;
System.Console.WriteLine($"Разница между мин и мах = {sum}");
}

Console.Clear();
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];

FillArray(array);
PrintArray(array);
Even(array);