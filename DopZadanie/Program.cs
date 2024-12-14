using System;
namespace DopZadanie
{
    class Program
    {
        static void Main()
        {
            Zina zina = new Zina();
            Resident resident1 = new Resident("Иван", 1234567890, new Problem(1, "Проблемы с подключением"), 7, true);
            Resident resident2 = new Resident("Мария", 987654321, new Problem(2, "Вопросы по оплате"), 4, false);
            Resident resident3 = new Resident("Сергей", 1111222233, new Problem(3, "Другая проблема"), 8, false);
            Resident resident4 = new Resident("Ольга", 444455556, new Problem(1, "Не греет батарея"), 2, true);
            zina.AddResident(resident1);
            zina.AddResident(resident2);
            zina.AddResident(resident3);
            zina.AddResident(resident4);
            while (zina.WaitingCount > 0)
            {
                zina.ProcessNextResident();
            }

            // Выводим состояние очередей
            zina.PrintQueuesStatus();
        }
    }
}