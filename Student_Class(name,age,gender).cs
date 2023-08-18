using System.Reflection.Metadata.Ecma335;

namespace Backend
{
    internal class Student
    {

        public string name;
        public int age;
        public string gender;
        public void setName(string? name = null)
        {
            this.name = name ?? "Unknown";
        }
        public void setAge(int? age = null)
        {
            this.age = age ?? default;
        }
        public void setGender(string gender = null)
        {
            this.gender = gender ?? "No data";
        }
        public void Display()
        {
            Console.WriteLine($"Name: {this.name}, age: {this.age}, gender: {this.gender}");
        }
        ~Student()
        {
            Console.WriteLine("Done!");
        }
    }
}
