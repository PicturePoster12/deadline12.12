using System;
namespace DZ
{
    internal class Task
    {
        public string Title { get; set; }
        public Department Department { get; set; }
        public Task(string title, Department department)
        {
            Title = title;
            Department = department;
        }

    }
}
