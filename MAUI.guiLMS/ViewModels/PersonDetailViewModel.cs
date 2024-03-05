using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string ClassificationString { get; set; } 
    }


}
