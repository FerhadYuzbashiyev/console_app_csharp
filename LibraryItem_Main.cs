using CSharp;
Connector con = new Connector();
con.DisplayInfo(new LibraryItem());
Console.WriteLine();
con.DisplayInfo(new Book());
Console.WriteLine();
con.DisplayInfo(new DVD());
Console.WriteLine();
con.DisplayInfo(new Magazine());