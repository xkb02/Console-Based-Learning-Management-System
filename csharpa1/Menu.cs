using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace csharpa1
{
    internal class Menu
    {
        public MenuHelper menuHelper = new MenuHelper();   
        public void DisplayMenu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Option 1..x");
                Console.WriteLine("1) Create a course");
                Console.WriteLine("2) Create a student");
                Console.WriteLine("3) List all students");
                Console.WriteLine("4) List all courses");
                Console.WriteLine("5) Add a student to a course");
                Console.WriteLine("6) List all students in a given course");
                Console.WriteLine("7) Search for a course");
                Console.WriteLine("8) Search for a student");
                Console.WriteLine("9) List all courses a student is taking");
                Console.WriteLine("10)Remove a student from a course");
                Console.WriteLine("11) Update a course's info");
                Console.WriteLine("12) Update a student's info");
                Console.WriteLine("13) Create an assingment for a course");
                Console.WriteLine("x) Exit");

                
                
                //switch for handling the menu options

                switch (Console.ReadLine())
                {
                    case "1":
                        menuHelper.courseManager.CreateCourse();
                        break;
                    case "2":
                        menuHelper.personManager.CreatePerson();
                        break;
                    case "3":
                       menuHelper.personManager.DisplayPeople();
                        break;
                    case "4":
                        menuHelper.courseManager.DisplayCourses();
                        break;
                    case "5":
                        menuHelper.AddPersonCourse();
                        break;
                    case "6":
                        menuHelper.courseManager.DisplayCourseRoster();
                        break;
                    case "7":
                        menuHelper.courseManager.CourseSearch();
                        break;
                    case "8":
                        Console.WriteLine("Enter Student Name for Search: ");
                        string? name = Console.ReadLine();
                        menuHelper.personManager.Search(name);
                        break;
                    case "9":
                        menuHelper.personManager.PersonCourseDisp();
                        break;
                    case "10":
                        menuHelper.RmPersonCourse();
                        break;
                    case "11":
                        menuHelper.courseManager.CourseUpdate();
                        break;
                    case "12":
                        menuHelper.personManager.PersonUpdate();
                        break;
                    case "13":
                        menuHelper.courseManager.AssignmentAdder();
                        break;
                    case "x":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again");
                        Console.WriteLine(" ");
                        break;
                }
            }
        }

    }

}
