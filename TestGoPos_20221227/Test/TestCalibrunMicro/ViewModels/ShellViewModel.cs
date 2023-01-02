using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Caliburn.Micro;

using TestCalibrunMicro.Models;

namespace TestCalibrunMicro.ViewModels
{
    public class ShellViewModel : Screen
    {
        public ShellViewModel()
        {
            Students.Add(new StudentModel { Name = "James", Grade = "3rd" });
            Students.Add(new StudentModel { Name = "Tony", Grade = "1st" });
            Students.Add(new StudentModel { Name = "Mike", Grade = "2nd" });

            _updateName = string.Empty;
            _updateGrade = string.Empty;
        }

        private BindableCollection<StudentModel> _students = new BindableCollection<StudentModel>();
        public BindableCollection<StudentModel> Students 
        { 
            get { return _students; }
            set { _students = value; }
        }

        private StudentModel _selectedStudent = new StudentModel();
        public StudentModel SelectedStudent
        {
            get { return _selectedStudent; }
            set
            {
                _selectedStudent = value;
                NotifyOfPropertyChange(() => _selectedStudent);
            }
        }

        private string _updateName; 

        public string UpdateName
        {
            get { return _updateName; }
            set 
            { 
                _updateName = value;
                //NotifyOfPropertyChange(() => _updateName);
            } 
        }

        // ComboBox의 ComboBoxItem에 들어갈 List
        public List<string> GradeList
        {
            get
            {
                return new List<string> { "1st", "2nd", "3rd" };
            }
        }

        private string _updateGrade;
        public string UpdateGrade
        {
            get { return _updateGrade; }
            set 
            { 
                _updateGrade = value; 
                NotifyOfPropertyChange(() => _updateGrade);
            }
        }


        // First Button
        //public void btnUpdate()
        //{
        //    string name = UpdateName;
        //    string grade = UpdateGrade;
        //    Students.Add(new StudentModel { Name = name, Grade = grade });
        //}

        // Second Button
        public void btnUpdate_Clicked(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            string buttonContent = button.Content.ToString();
            string name = UpdateName;
            string grade = UpdateGrade;

            MessageBox.Show(buttonContent);

            Students.Add(new StudentModel { Name = name, Grade = grade });
        }
    }
}
