namespace CSharp
{
    public class DVD : LibraryItem
    {
        public string director = "Robbie Johnson";
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(director);
        }
    }
}
