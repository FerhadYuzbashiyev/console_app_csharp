using System;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int to double 
            try
            {
                int intValue = int.Parse(Console.ReadLine());
                double doubleValue = Convert.ToDouble(intValue);
                Console.WriteLine(doubleValue);
                Console.WriteLine(doubleValue / 3); // will be divided as a double variable
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Wrong datatype used, try int");
            }

            // float to int
            /*string stringValue = Console.ReadLine();
            float floatValue;
            try
            {
                floatValue = float.Parse(stringValue);
                int intValue = (int)floatValue;
                Console.WriteLine(intValue);
                Console.WriteLine(intValue / 3); // Will be divided as an int variable
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Wrong datatype used, try float");
            }*/

            // string to int
            /*string stringValue = Console.ReadLine();
            int intValue;
            try
            {
                intValue = Convert.ToInt32(stringValue);
                Console.WriteLine(intValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Wrong datatype used, try string including only int dataype");
            }*/

            // bool to string 
            /*string ReadLine = Console.ReadLine();
            bool boolValue;
            try
            {
                boolValue = bool.Parse(ReadLine);
                string stringValue = Convert.ToString(boolValue);
                Console.WriteLine(stringValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Wrong datatype used, try boolean");
            }*/

            // double to string
            /*string ReadLine = Console.ReadLine();
            double doubleValue;
            try
            {
                doubleValue = double.Parse(ReadLine);
                string stringValue = Convert.ToString(doubleValue);
                Console.WriteLine(stringValue);
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Wrong datatype used, try double");
            }*/



            Console.ReadLine();
        }
    }
}