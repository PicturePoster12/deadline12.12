using System;
namespace DZ
{
    class SystemsEngineer: Employee
    {
        public string Name => "Ильшат";
        public bool AcceptTask(Task task)
        {
            return task.Department == Department.Systems ? true : false;
        }
    }
}
