using MAUI.guiLMS.ViewModels;
using csharpa1;
using static csharpa1.Person;


namespace MAUI.guiLMS.Views;

public partial class PersonDetailView : ContentPage
{
    public PersonDetailView()
    {
        InitializeComponent();

        BindingContext = new PersonDetailViewModel();
    }

    //public int PersonId
    //{
    //    set; get;
    //}

    private void OkClick(object sender, EventArgs e)
    {
        //(BindingContext as PersonDetailViewModel).AddPerson();

        var context = BindingContext as PersonDetailViewModel;
        PersonClassification classification = PersonClassification.Freshman;
        switch (context.ClassificationString)
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
      PersonManager.Current.AddPerson(new Person { Name = context.Name, Classification = classification });
        Shell.Current.GoToAsync("//Instructor");
    }


private void CancelClick(object sender, EventArgs e)
{
    Shell.Current.GoToAsync("//Instructor");
}

private void OnLeaving(object sender, NavigatedFromEventArgs e)
{
    BindingContext = null;
}

//private void OnArriving(object sender, NavigatedToEventArgs e)
//{
//    BindingContext = new PersonDetailViewModel(PersonId);
//}
}
