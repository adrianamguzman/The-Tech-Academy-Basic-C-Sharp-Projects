using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the Students First and Last Name?");
            Student newStudent = new Student();
            newStudent.Name = Console.ReadLine();
            Console.WriteLine("What Subject is the student adding to their schedule?");
            Subject newSubject = new Subject();
            newSubject.Name = Console.ReadLine();
            Console.WriteLine("Is the student Full time or Part Time? N/A also acceptable.");
            Student newStatus = new Student();
            newStatus.Name = Console.ReadLine();



            using (var db = new StudentContext())
            { 
                var student = new Student() {Name = newStudent.Name};
                var stat = new Student() { Status = newStatus.Status };
                var subj = new Subject() { Name = newSubject.Name };
                
                

                student.Subjects.Add(subj);


                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public virtual List<Subject> Subjects { get; set; }
        public Student()
        {
            this.Subjects = new List<Subject>();
        }

    }
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }

        public virtual Student Student { get; set; }

    }
    public class StudentContext : DbContext

    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }

}
   
