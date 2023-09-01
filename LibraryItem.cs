namespace CSharp
{
    public class LibraryItem
    {
        public string title = "Some Title";
        public string publicYear = "2020";
        public virtual void DisplayInfo()
        {
            Console.WriteLine(title);
            Console.WriteLine(publicYear);
        }
    }
}
