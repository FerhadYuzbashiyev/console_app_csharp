string a = Console.ReadLine();
string splitter = " ";
Console.Write("Uppercase: ");
Console.WriteLine(a.ToUpper());
Console.Write("Lowercase: ");
Console.WriteLine(a.ToLower());
Console.Write("Total characters: ");
Console.WriteLine(a.Length);
Console.Write("First 5 characters: ");
Console.WriteLine(a.Substring(0,5));
Console.Write("Last 5 characters: ");
Console.WriteLine(a.Substring(a.Length - 5));
Console.Write("Replace 'a' with '*': ");
Console.WriteLine(a.Replace("a","*"));
Console.Write("Contains 'Csharp': ");
Console.WriteLine(a.Contains("Csharp"));
Console.Write("Index of: ");
Console.WriteLine(a.IndexOf("e"));
Console.Write("Split: ");
string[] dem = a.Split(splitter);
for (int i = 0; i < dem.Length; i++)
{
    Console.Write(dem[i]);
}