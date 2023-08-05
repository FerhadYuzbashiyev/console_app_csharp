int size;
Console.Write($"Enter a number: ");
size = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] mult_1 = new int[size];
int[] mult_2 = new int[size];
for(int i = 0; i < size; i++)
{
    mult_1[i] = i + 1;
    mult_2[i] = i + 1;
}

for(int i = 0; i < size; i++)
{
    for(int j = 0; j < size; j++)
    {
        Console.WriteLine($"{mult_1[i]} * {mult_2[j]} = {mult_1[i] * mult_2[j]}");
    }
    Console.WriteLine();
}