using Test;
int choose;
bool CodeExit = true;
Patron p = new Patron();
Book b = new Book();
Save s = new Save();
/*p.SetFullPatronInfo();
p.SetFullPatronInfo();
p.SetFullPatronInfo();
p.ShowFullInfo();*/
//b.ShowFullInfo();
while (CodeExit)
{
    Console.WriteLine("Choose one option: ");
    Console.WriteLine("1) Create new Patron info");
    Console.WriteLine("2) Show patron Info");
    Console.WriteLine("3) Search book info");
    Console.WriteLine("4) Save Info");
    Console.WriteLine("5) Exit");
    choose = int.Parse(Console.ReadLine());
    if(choose < 1 || choose > 5)
    {
        Console.WriteLine("Choose between 1 and 5");
    }
    else
    {
        if(choose == 1)
        {
            p.SetFullPatronInfo();
        }
        if(choose == 2)
        {
            p.ShowFullInfo();
        }
        if(choose == 3)
        {
            b.ShowFullInfo();
        }
        if(choose == 4)
        {
            s.SaveInfo();
        }
        if(choose == 5)
        {
            CodeExit = false;
        }
    }
}