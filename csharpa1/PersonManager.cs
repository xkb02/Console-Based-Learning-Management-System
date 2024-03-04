﻿using csharpa1.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpa1
{
    public class PersonManager
    {

        //creates a list of all the people created in the program
        //public List<Person> people = new List<Person>();

        public IEnumerable<Person?>? people
        {
            get {
                return FakeDatabase.people.Where(p => p is Person).Select(p => p as Person);
            }
        }

        private static PersonManager? _instance;

        //functions
        public void AddPerson(Person person)
        {
            FakeDatabase.people.Add(person);
        }

        public PersonManager()
        {
            
        }
        public void PersonUpdate()
        {
            Console.WriteLine("Update a Student's Information, Enter the name of the student you wish to update: ");
            var name = Console.ReadLine();
            bool found = false;
            foreach (var person in people)
            {
                if (person.Name == name)
                {
                    found = true;
                    Console.WriteLine("Enter the new student name: ");
                    person.Name = Console.ReadLine();
                    Console.WriteLine("Enter the new student classification: ");
                    person.Classification = Console.ReadLine();
                    Console.WriteLine("Enter the new student grades: ");
                    person.Grades = Console.ReadLine();
                    Console.WriteLine("Student " + person.Name + " updated.");
                }
            }
            if (!found)
            {
                Console.WriteLine("Course not found.");

            }
        }
        public void PersonCourseDisp()
        {

            Console.WriteLine("Student Courses - Enter a name ");
            string? name = Console.ReadLine();

            bool found = false;
            foreach (var person in people)
            {
                if (person.Name == name)
                {
                    found = true;
                    person.ListEnrolled();
                }
            }
            if (!found)
            {
                Console.WriteLine("Student not found");

            }

        }
        //public void PersonSearch()
        //{

        //    Console.WriteLine("Student Search - Pleease enter a name: ");
        //    string? name = Console.ReadLine();

        //        bool found = false;
        //        foreach (var person in people)
        //        {
        //        if (person.Name == name)
        //        {
        //            found = true;
        //            Console.WriteLine("Student Found!");
        //            Console.WriteLine(person);
        //        }
        //        }
        //        if (!found)
        //        {
        //            Console.WriteLine("Student not found");

        //        }

        //}

        public static PersonManager Current
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PersonManager();
                }

                return _instance;
            }
        }
        public IEnumerable<Person?> Search(string query)
        {
            return people.Where(s => (s != null) && s.Name.ToUpper().Contains(query.ToUpper()));
        }

        //public decimal GetGPA(int studentId)
        //{
        //    var courseSvc = CourseManager.Current;
        //    var courses = courseSvc.courses.Where(c => c.Roster.Select(s => s.Id).Contains(studentId));

        //    var totalGradePoints = courses.Select(c => courseSvc.GetGradePoints(c.Id, studentId) * c.CreditHours).Sum();
        //    var totalCreditHours = courses.Select(c => c.CreditHours).Sum();

        //    return totalGradePoints / (totalCreditHours > 0 ? totalCreditHours : -1);
        //}


        public void CreatePerson()
        {
            string? name;
            string? classification;
            string? grades;
            string? id;

            Console.WriteLine("Create a Student");
            Console.WriteLine(" ");
            Console.WriteLine("Enter the student name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the student ID");
            id = Console.ReadLine();
            Console.WriteLine("Enter the student classification (Fr/So/Jr/Sr)");
            classification = Console.ReadLine();
            Console.WriteLine("Enter the Student grades (separate by space)");
            grades = Console.ReadLine();

            Person? newPerson = new Person(name, classification, grades);

            Console.WriteLine("Student " + newPerson.Name + " created.");

            AddPerson(newPerson);


        }
        
        
        public void DisplayPeople()
        {
            Console.WriteLine("List of People: ");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}