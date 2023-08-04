// Student System
using System;

namespace Lesson
{
    public class Student
    {
        private int ID;
        private string Name;
        private string Surname;
        private DateTime Birthdate;
        
        public void setName(string name)
        {
            this.Name = name;
        }
        public string getName() {
            return this.Name;
        }
        public void setSurname(string surname)
        {
            this.Surname = surname;
        }
        public string getSurname()
        {
            return this.Surname;
        }
        public void setID(int ID)
        {
            this.ID = ID;
        }
        public int getID()
        {
            return this.ID;
        }
        public void setBirthdate(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
        public DateTime getBirthdate()
        {
            return this.Birthdate;
        }
        public void Display()
        {
            Console.WriteLine("{0}. {1} {2} - {3}",getID(),getName(),getSurname(),getBirthdate());
            Console.WriteLine("----------------------------------------");
        }
    }
}
