using System;
namespace DZ
{
    class FinanceDirector: Employee
    {
        public string Name => "Рашид";
        public bool AcceptTask(Task task) 
        {
            return task.Department == Department.Finance ? true : false;
        }
    }
}
