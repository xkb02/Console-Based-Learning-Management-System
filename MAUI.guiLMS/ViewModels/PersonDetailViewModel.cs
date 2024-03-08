using csharpa1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharpa1.Person;

namespace MAUI.guiLMS.ViewModels
{
    public class PersonDetailViewModel
    {
        public PersonDetailViewModel()
        {
        }

        public PersonDetailViewModel(object personId)
        {

        }

        public string Name { get; set; }

        public int? Id { get; set; }
        public string ClassificationString { get; set; }

        int id = 1;
        public void AddPerson()
        {
            PersonClassification classification = PersonClassification.Freshman;
            switch (ClassificationString)
            {
                case "S":
                    classification = PersonClassification.Senior;
                    break;
                case "O":
                    classification = PersonClassification.Sophomore;
                    break;
                case "J":
                    classification = PersonClassification.Junior;
                    break;
                case "F":
                    classification = PersonClassification.Freshman;
                    break;

            }
            
            PersonManager.Current.AddPerson(new Person { Name = Name, Classification = classification, Id = id });
            id++;
            Shell.Current.GoToAsync("//Instructor");
        }
    }


}
