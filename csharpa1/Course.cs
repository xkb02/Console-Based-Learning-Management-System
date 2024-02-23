﻿using System;
using System.Collections.Specialized;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace csharpa1
{
    internal class Course
    {
        //private fields
        private string? code;
        private string? name;
        private string? description;
        private List<Person>? roster;
        private List<Module>? modules;
        private List<Assignment>? assignments;


        


        //parameterized constructor
        public Course(string? cCode, string? cName, string? cDescription)
            {
                code = cCode;
                name = cName;
                description = cDescription; 
                roster = new List<Person>();
                modules = new List<Module>();
                assignments = new List<Assignment>();
            }

        public Course()
        {

        }
        //public properties
        
        public List <Person>? Roster
        {
            get { return roster; }
            set { roster = value; }
        }

        public List <Module>? Modules
        {
            get { return modules; }
            set { modules = value; }
        }

        public List<Assignment>? Assignments
        {
            get { return assignments; }
            set { assignments = value; }
        }
        
        public  string? Code 
        {
            get { return code; }
            set { code = value; }
        }

        public string? Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }

        public string? Description
        {
            get { return description; }
            set { description = value; }
        }

        //functions

        public void AddStudent(Person person)
        {
            Console.WriteLine("Adding student " + person.Name);
            roster.Add(person);

        }
        
        public void RmStudent(Person person)
        {
            Console.WriteLine("Removing student " + person.Name);
            roster.Remove(person);

        }
        public void DisplayRoster()
        {
            Console.WriteLine("Printing course roster");
                 
            foreach(var person in roster)
            {
                Console.WriteLine(person);
            }
            
        }

       // public void UpdateInfo(string)
        public override string ToString()
        {
            return name + " | Code: " + code + " | Description: " + description;
        }

        
    }
}
