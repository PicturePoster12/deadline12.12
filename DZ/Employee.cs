using System;
namespace DZ
{
    interface Employee
    {
        string Name { get; }
        bool AcceptTask(Task task);
    }
}
