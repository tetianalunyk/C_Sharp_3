using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            StudentCollection studentCollection = new StudentCollection();
            studentCollection.AddDefaults();
            Console.WriteLine("First task: Collection of students - " + studentCollection);
            /*studentCollection.AddStudents(
                    TestCollections.GetStudent(3),
                    TestCollections.GetStudent(2),
                    TestCollections.GetStudent(5),
                    TestCollections.GetStudent(1),
                    TestCollections.GetStudent(4)
                    
                );

            Console.WriteLine("First task: Collection of students - " + studentCollection);
            studentCollection.SortBySurname();
            Console.WriteLine("\n\nSecond task:\nSorted By Surname:\n" + studentCollection);
            studentCollection.SortByDate();
            Console.WriteLine("\nSorted By Date:\n" + studentCollection);
            studentCollection.SortByEverage();
            Console.WriteLine("\nSorted By Everage:\n" + studentCollection);

            Console.WriteLine("\n\nThird task:\nGet Max Everage: " + studentCollection.GetMaxEvarage());
            int value = 3;
            Console.WriteLine("\nEverage mark in group:\n" + string.Join(" ; ", studentCollection.EvarageMarkGroup(value).Select(x => x.GetEverage).ToArray()));
            Console.WriteLine("\nPeople with Master degree:\n" + string.Join(" ; ", studentCollection.GetListOfMasters().Select(x => x._surname).ToArray()));

            Console.WriteLine("\n\nFourth task:\n");
            TestCollections test = new TestCollections(10);
            Console.WriteLine("Searching time:");
            test.MeasureTime();




            /*Console.WriteLine("\nFirst task - two objects: ");
            DateTime date = new DateTime(1999, 09, 24);
            Person Tania = new Person("Tetiana", "Lunyk", date);
            Person Tetiana = new Person("Tetiana", "Lunyk", date);
            Console.WriteLine("== " + (Tania == Tetiana));
            Console.WriteLine("Equals: " + Tetiana.Equals(Tania));
            Console.WriteLine("Hash : " + Tania.GetHashCode() + " " + Tetiana.GetHashCode());

            Console.WriteLine("\nSecond task - object Student: ");
            Student Lunyk = new Student("Tetiana", "Lunyk", date, Education.Bachelor, 311);
            Exam[] first = new Exam[2];
            first[0] = new Exam("Programming", 5, new DateTime(1999, 09, 24));
            first[1] = new Exam("Math", 2, new DateTime(1999, 09, 24));
            Lunyk.AddExams(first);
            Test[] first_t = new Test[1];
            first_t[0] = new Test("Java", true);
            Lunyk.AddCredits(first_t);
            Console.WriteLine(Lunyk.ToString());
            Console.WriteLine("\nThird task show Person from Student : ");
            Console.WriteLine(Lunyk.PersonBase);

            Console.WriteLine("\nFifth task exception : ");
            try
            {
                Lunyk.group = -1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
            Console.WriteLine("\nDeep copy: ");
            Student Me = (Student)Lunyk.DeepCopy();
            Console.WriteLine(Me.Equals(Lunyk));
            Lunyk._Exam[0].subject = "kjhgf";
            Exam[] second = new Exam[1];
             second[0] = new Exam("C_sharp", 3, new DateTime(1999, 09, 24));
             Lunyk.AddExams(second);
            Console.WriteLine(Me + "" + Lunyk);

            Console.WriteLine("\nSixth task foreach Papers :");
            foreach (Exam ex in Lunyk.GetExamsMoreThen(3))
            {
                Console.WriteLine(ex);
            }
            string str;
            str=Console.ReadLine();*/
        }
    }
}
