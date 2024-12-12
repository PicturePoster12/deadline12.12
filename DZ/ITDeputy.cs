using System;
namespace DZ
{
    class ITDeputy: Employee
    {
        public string Name => "Володя";
        public bool AcceptTask(Task task)
        {
            return task.Department == Department.InformationTechnology ? true : false;
        }
    }
}
