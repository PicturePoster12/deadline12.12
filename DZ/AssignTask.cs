using System;
namespace DZ
{
    class Assign
    {
        public void AssignTask(Employee assignee, Task task)
        {
            if (assignee.AcceptTask(task))
            {
                Console.WriteLine($"Задачу '{task.Title}' взял сотрудник {assignee.Name}.");
            }
            else
            {
                Console.WriteLine($"Сотрудник {assignee.Name} отказался взять задачу '{task.Title}'.");
            }
        }
    }
}
