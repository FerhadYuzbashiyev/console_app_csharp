namespace CSharp
{
    public class Book : LibraryItem
    {
        public string author = "George Leone";
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(author);
        }
    }
}
