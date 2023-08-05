int size, max, min;
Console.Write($"Enter massive size: ");
size = int.Parse(Console.ReadLine());
int[] arr = new int[size];

for(int i = 0; i < size; i++)
{
    Console.Write($"arr[{i}] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
max = arr[0];
min = arr[1];
for(int i = 0; i < size; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
    if(min > arr[i])
    {
        min = arr[i];
    }
}
Console.WriteLine($"Minimum is {min} and maximum is {max}");