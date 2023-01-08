using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace _09.ListView.Model
{
    public class Model:ObservableCollection<Student>
    {
        // 생성자
        public Model() 
        {
            Add(new Student() { Name = "범범조조", Age = 28, PhoneNumber = "010-1234-1234" });
            Add(new Student() { Name = "안정환", Age = 20, PhoneNumber = "010-1234-1235" });
            Add(new Student() { Name = "아이유", Age = 38, PhoneNumber = "010-1234-1236" });
            Add(new Student() { Name = "정형동", Age = 21, PhoneNumber = "010-1234-1237" });
            Add(new Student() { Name = "박명수", Age = 54, PhoneNumber = "010-1234-1238" });
            Add(new Student() { Name = "하하", Age = 47, PhoneNumber = "010-1234-1239" });
            Add(new Student() { Name = "유재석", Age = 48, PhoneNumber = "010-1234-1230" });
        }
    }
    public class Student
    { 
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
    }
}
