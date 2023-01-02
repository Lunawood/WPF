using System;

namespace TestCalibrunMicro.Models
{
    public class StudentModel
    {
        public StudentModel()
        {
            this.Name = string.Empty;
            this.Grade = string.Empty;
        }

        public StudentModel(string name, string grade)
        {
            this.Name = name;
            this.Grade = grade;            
        }


        public string Name { get; set; }
        public string Grade { get; set; } 
    }
}