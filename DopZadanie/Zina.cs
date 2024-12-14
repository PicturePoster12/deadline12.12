using System;
namespace DopZadanie
{
    public class Zina
    {
        private Stack<Resident> waitingResidents;
        private Queue[] queues;
        public Zina()
        {
            waitingResidents = new Stack<Resident>();
            queues = new Queue[3];
            for (int i = 0; i < queues.Length; i++)
            {
                queues[i] = new Queue();
            }
        }
        public void AddResident(Resident resident)
        {
            waitingResidents.Push(resident);
        }
        public void ProcessNextResident()
        {
            if (waitingResidents.Count == 0)
            {
                return;
            }

            var currentResident = waitingResidents.Pop();
            int windowIndex = GetWindowIndex(currentResident.Problem.Number);

            if (!currentResident.IsSmart)
            {
                windowIndex = RandomizeWindow(windowIndex);
            }

            if (currentResident.Scandalousness >= 5)
            {
                Console.WriteLine($"{currentResident.Name} хочет пропустить очередь.");
                int positionsToSkip = AskUserForPositionsToSkip();
                queues[windowIndex].SkipAhead(currentResident, positionsToSkip);
            }
            else
            {
                queues[windowIndex].Enqueue(currentResident);
            }
        }
        private int GetWindowIndex(int problemNumber)
        {
            switch (problemNumber)
            {
                case 1:
                    return 0;
                case 2:
                    return 1;
                default:
                    return 2;
            }
        }
        private int RandomizeWindow(int currentWindowIndex)
        {
            Random random = new Random();
            while (true)
            {
                int randomWindowIndex = random.Next(queues.Length);
                if (randomWindowIndex != currentWindowIndex)
                {
                    return randomWindowIndex;
                }
            }
        }
        private int AskUserForPositionsToSkip()
        {
            Console.WriteLine("На сколько позиций хотите пропустить очередь? ");
            byte positionsToSkip;
            while (!byte.TryParse(Console.ReadLine(), out positionsToSkip))
            {
                Console.WriteLine("Пожалуйста, введите целое число: ");
            }
            return positionsToSkip;
        }
        public void PrintQueuesStatus()
        {
            for (int i = 0; i < queues.Length; i++)
            {
                Console.WriteLine($"Очередь в окно №{i + 1}:");
                foreach (var resident in queues[i].GetResidents())
                {
                    Console.WriteLine($"- {resident.Name}");
                }
            }
        }
        public int WaitingCount => waitingResidents.Count;
    }
}
