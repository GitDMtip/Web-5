//Задача 34
int[] numbers = new int[8];
void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
{
    array[i] = new Random().Next(min, max);
}
}
void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ )
{
    Console.Write(array[i] + " ");
}
}

int Pos(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
  {
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = Pos(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");