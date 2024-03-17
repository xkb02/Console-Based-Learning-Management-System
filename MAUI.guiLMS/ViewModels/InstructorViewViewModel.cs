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
        
        public Person SelectedPerson { get; set; }
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public void AddClick(Shell s)
        {
            s.GoToAsync($"//PersonDetail?personId=0");
        }
        public void EditClick(Shell s)
        {
            var idParam = SelectedPerson?.Id ?? 0;
            s.GoToAsync($"//PersonDetail?personId={idParam}");
        }

        public void RefreshView()
        {
            NotifyPropertyChanged(nameof(People)); 
        }

        internal void RemoveClick()
        {
            if(SelectedPerson == null) { return; }

            PersonManager.Current.RemovePerson(SelectedPerson);
            RefreshView();
        }
    }
}
