//using Android.App.People;
using csharpa1;
using csharpa1.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.guiLMS.ViewModels
{
    public class InstructorViewViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People {
            get
            {
                return new ObservableCollection<Person>(PersonManager.Current.people);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public void AddClick(Shell s)
        {
            s.GoToAsync("//PersonDetail");
        }

        public void RefreshView()
        {
            NotifyPropertyChanged(nameof(People)); 
        }

    }
}
