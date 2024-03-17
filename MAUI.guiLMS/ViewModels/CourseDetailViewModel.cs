using csharpa1;

namespace MAUI.guiLMS.ViewModels
{
    internal class CourseDetailViewModel
    {
        public CourseDetailViewModel()
        {
            course = new Course();
        }

        public string Name
        {
            get => course?.Name ?? string.Empty;
            set { if (course != null) course.Name = value; }
        }
        public string Description
        {
            get => course?.Description ?? string.Empty;
            set { if (course != null) course.Description = value; }
        }
        public string Prefix
        {
            get => course?.Prefix ?? string.Empty;
            set { if (course != null) course.Prefix = value; }
        }
        public int Id { get; set; }

        public string CourseCode
        {
            get => course?.Code ?? string.Empty;
        }

        private Course course;

        public void AddCourse(Shell s)
        {
            CourseManager.Current.AddCourse(course);
            s.GoToAsync("//Instructor");
        }
    }
}