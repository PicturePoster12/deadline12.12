using System;
namespace DZ
{
    class AutomationDirector: Employee
    {
        public string Name => "О Ильхам";
        public bool AcceptTask(Task task)
        {
            return task.Department == Department.Automation ? true : false;
        }
    }
}
