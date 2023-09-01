namespace CSharp
{
    public class Magazine : LibraryItem
    {
        public int issueNum = 12;
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(issueNum);
        }
    }
}
