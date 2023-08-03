using System;
using System.Security.AccessControl;

namespace Lesson
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Student Ferhad = new Student();
            DateTime birthdate_1 = new DateTime(2004, 8, 6);
            Ferhad.setID(1);
            Ferhad.setName("Ferhad");
            Ferhad.setSurname("Yuzbashiyev");
            Ferhad.setBirthdate(birthdate_1);
            Ferhad.Display();
            Student Tamerlan = new Student();
            DateTime birthdate_2 = new DateTime(2000, 5, 5);
            Tamerlan.setID(2);
            Tamerlan.setName("Tamerlan");
            Tamerlan.setSurname("Aliyev");
            Tamerlan.setBirthdate(birthdate_2);
            Tamerlan.Display();
            Student Kamil = new Student();
            DateTime birthdate_3 = new DateTime(1964, 1, 2);
            Kamil.setID(3);
            Kamil.setName("Kamil");
            Kamil.setSurname("Yaqizarov");
            Kamil.setBirthdate(birthdate_3);
            Kamil.Display();


        }
    }
}