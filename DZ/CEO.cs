using System;
namespace DZ
{
    class CEO: Employee
    {
        public string Name => "Тимур";
        public bool AcceptTask(Task task)
        {
            return true;
        }
    }
}
