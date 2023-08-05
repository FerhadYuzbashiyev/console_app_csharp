int size;
Console.Write("Enter size: ");
size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
int max, max_second, max_ind = 0;
for (int i = 0; i < size; i++)
{
    Console.Write($"arr[{i}] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
max = arr[0];
for (int i = 0; i < size; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
        max_ind = i;
    }
}
max_second = arr[0];
for (int i = 0; i < size; i++)
{
    arr[max_ind] = int.MinValue;
    if (max_second < arr[i])
    {
        max_second = arr[i];
    }
}

Console.WriteLine(max_second);