using System;
namespace DZ
{
    class ITHead: Employee
    {
        public string Name => "Оркадий";
        public bool AcceptTask(Task task)
        {
            return task.Department == Department.InformationTechnology ? true : false;
        }
    }
}
