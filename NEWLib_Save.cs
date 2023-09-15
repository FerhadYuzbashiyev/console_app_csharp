using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Save : Patron
    {
        public void SaveInfo()
        {
            string[] arrData = { "A", "B", "C" };
            string directoryPath = @"C:\Users\Gaming PC\Downloads";
            string fileName = "data.txt";
            string filePath = Path.Combine(directoryPath, fileName);
            try
            {
                Directory.CreateDirectory(directoryPath);
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (var item in arrData)
                    {
                        sw.WriteLine(item);
                    }
                }
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
