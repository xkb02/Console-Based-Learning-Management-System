using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpa1.Database
{
    public static class FakeDatabase
    {
        public static List<Person> people 
        {
                get
                { 
                    return new List<Person>(); 
                }
        }
        public static List<Course> courses
        { 
            get 
            { 
                return new List<Course>(); 
            } 
        }
    }

}
