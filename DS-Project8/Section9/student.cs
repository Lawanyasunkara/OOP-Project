using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    public class student
    {
        public string name;
        public int classes;
        public char section;

        public virtual void gets()
        {
            Console.WriteLine("Hello Enter the student details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter the student name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the classes");
            classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the Section");
            section = Convert.ToChar(Console.ReadLine());
        }
        public virtual void prints()
        {
            Console.WriteLine("Print the Student details");
            Console.WriteLine( name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
        }
    }
    public class teacher : student
    {
        public string subject;
        public override void gets()
        {
            Console.WriteLine("Please Enter the Teacher details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter the Teacher name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the classes");
            classes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the section");
            section = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Subject");
            subject = Console.ReadLine();
        }
        public override void prints()
        {
            Console.WriteLine("print the student details");
            Console.WriteLine(name);
            Console.WriteLine(classes);
            Console.WriteLine(section);
            Console.WriteLine(subject);
        }
    }
    public class subject : student
    {
        public string subject_code;
        public override void gets()
        {
            Console.WriteLine(" Hey Enter the subject details");
            Console.WriteLine("-------------------");
            Console.WriteLine("Enter the subject name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the subject code");
            subject_code = Console.ReadLine();

        }
        public override void prints()
        {
            Console.WriteLine(" Finally print the Subject details");
            Console.WriteLine(name);
            Console.WriteLine(subject_code);

        }
    }

}