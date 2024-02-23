using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpa1
{
    internal class MenuHelper
    {
        public CourseManager courseManager = new CourseManager();
        public PersonManager personManager = new PersonManager();


        public void AddPersonCourse()
        {
            string? name;
            string? code;
            bool studentFound = false;
            bool courseFound = false;
            Console.WriteLine("Enter the Student's name");
            name = Console.ReadLine();
            Person foundPerson; //flag
            Course foundCourse; //=  new Course(); //flag
            foreach (var person in personManager.people)
            {
                if (person.Name == name)
                {
                    studentFound = true;
                    foundPerson = person;
                    Console.WriteLine("Enter the code of the course that you Wish to add" + " " + person.Name);
                    code = Console.ReadLine();
                    foreach (Course course in courseManager.courses)
                    {
                        if (course.Code == code)
                        {
                            foundCourse = course;
                            courseFound = true;
                            foundCourse.AddStudent(foundPerson);
                            foundPerson.AddEnrolled(foundCourse.Name);
                            break;
                        }
                    }
                    if (!courseFound)
                    {
                        Console.WriteLine("Course not found");
                    }
                    break;
                }
            }
            if (!studentFound)
            {
                Console.WriteLine("Student not found");
            }

        }


        public void RmPersonCourse()
        {
            string? name;
            string? code;
            bool studentFound = false;
            bool courseFound = false;
            Console.WriteLine("Enter the Student's name");
            name = Console.ReadLine();
            Person foundPerson; //flag
            Course foundCourse; //=  new Course(); //flag
            foreach (var person in personManager.people)
            {
                if (person.Name == name)
                {
                    studentFound = true;
                    foundPerson = person;
                    Console.WriteLine("Enter the code of the course that you Wish to remove" + " " + person.Name);
                    code = Console.ReadLine();
                    foreach (Course course in courseManager.courses)
                    {
                        if (course.Code == code)
                        {
                            foundCourse = course;
                            courseFound = true;
                            foundCourse.RmStudent(foundPerson);
                            foundPerson.rmEnrolled(foundCourse.Name);
                            break;
                        }
                    }
                    if (!courseFound)
                    {
                        Console.WriteLine("Course not found");
                    }
                    break;
                }
            }
            if (!studentFound)
            {
                Console.WriteLine("Student not found");
            }

        }
    }
}
