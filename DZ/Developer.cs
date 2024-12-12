using System;
namespace DZ
{
    class Developer: Employee
    {
        public string Name => "Сергей";
        public bool AcceptTask(Task task)
        {
            return task.Department == Department.Development ? true : false;
        }
    }
}
