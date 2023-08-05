    double avg(int size, params int[] arr)
{
    int sum = 0;
    size = arr.Length;
    for(int i = 0; i < size; i++)
    {
        sum += arr[i];
    }
    return (double)sum / size; ;
}
int size;
Console.Write($"Enter massive size: ");
size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for(int i = 0; i < size; i++)
{
    Console.Write($"arr[{i}] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine(avg(size, arr));