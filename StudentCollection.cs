using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentCollection
    {
        private List<Student> students;
        public void AddDefaults()
        {
            Student[] defaul = new Student[2];
            DateTime date = new DateTime(1999, 09, 24);
            defaul[0] = new Student(new Person("Tetiana", "Lunyk", date), Education.Bachelor, 311, new List<Test> { new Test("Java", true)}, new List<Exam> { new Exam("Programming", 5, new DateTime(1999, 09, 24))});
            defaul[1] = new Student(new Person("Tetiana", "Kukhta", date), Education.Bachelor, 311, new List<Test> { new Test("Java", false) }, new List<Exam> { new Exam("Programming", 3, new DateTime(1999, 09, 24)) });
            students.AddRange(defaul);
        }

        public void AddStudents(params Student[] range)
        {
            students = new List<Student>();
            foreach(var stud in range)
            {
               students.Add(stud);
            }
        }

        public override string ToString()
        {
            string temp = "";
            for (int i = 0; i < students.Count; i++)
                temp += "\nName " + students[i]._name + "\nSurname " + students[i]._surname + "\nDate of birth: " + students[i]._dateOfBirth + students[i].ToString() + "\r\n";
            return "Students: " + temp;
        }

        public virtual string ToShortString()
        {
            string temp = "";
            for (int i = 0; i < students.Count; i++)
                temp += "\nName: " + students[i]._name + "\nSurname: " + students[i]._surname + "\nDate of Birth: " + students[i]._dateOfBirth +"\nEducation: "+ students[i]._educ +"\nGroup: "+ students[i].group + "\nCount exams: "+ students[i]._Exam.Count + "\nEveradge: " + students[i].GetEverage + "\nCount tests: " + students[i]._Test.Count + "\r\n";
            return "Students: " + temp;
        }

        public void SortBySurname() => students.Sort();// (x,y) => x.CompareTo(y));
        

        public void SortByDate()
        {
            students.Sort((x, y) => new Student().Compare(x,y));
        }

        public void SortByEverage()
        {
            students.Sort((x, y) => new AverageMarkComparer().Compare(x, y));
        }

        public double GetMaxEvarage()
        {
            return students.Count != 0 ? students.Select(x => x.GetEverage).Max() : 0;
        }

        public List<Student> EvarageMarkGroup(double value)
        {
            return students.Where(x => Math.Abs(x.GetEverage - value)<0.001).ToList();
        }

        public IEnumerable<Student> GetListOfMasters()
        {
            return students.Where(x => x._educ == Education.Master);
        }


    }
}
