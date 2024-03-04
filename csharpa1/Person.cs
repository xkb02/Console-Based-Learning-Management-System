﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharpa1
{
    public class Person
    {
        //private fields
        private string? name;
        private string? classification;
        private string? grades;
        private string? id;
        private List<string>? enrolledCourses;

        //constructor
        public Person(string? pName, string? pClassification, string? pGrades)
        {
            Name = pName;
            Classification = pClassification;
            Grades = pGrades;
            EnrolledCourses = new List<string>();
        }

        //public properties
        
        public List<string> EnrolledCourses
        {
            get { return enrolledCourses; }
            set { enrolledCourses = value; }
        }

        public string? Id
        {
            get { return name; }
            set { name = value; }
        }
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public string? Classification 
        { 
            get { return classification; } 
            set { classification = value; } 
        }  

        public string? Grades
        {
            get { return grades; }
            set { grades = value; }
        }



        public void AddEnrolled(string name)
        {
            Console.WriteLine("to course " + name);
            enrolledCourses.Add(name);
        }

        public void rmEnrolled(string name)
        {
            Console.WriteLine("from course " + name);
            enrolledCourses.Remove(name);
        }

        public void ListEnrolled()
        {
            Console.WriteLine("List of courses Student is enrolled in: ");
            foreach (String course in enrolledCourses) 
            { 
                Console.WriteLine(course);
            }
        }


        public override string ToString()
        {
            return name + " | classification:  " + classification + " | grades: " + grades;
        }
    }
}