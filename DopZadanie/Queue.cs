using System;
namespace DopZadanie
{
    public class Queue
    {
        private List<Resident> residents;
        public Queue()
        {
            residents = new List<Resident>();
        }
        public void Enqueue(Resident resident)
        {
            residents.Add(resident);
        }
        public Resident Dequeue()
        {
            if (residents.Count > 0)
            {
                var firstResident = residents[0];
                residents.RemoveAt(0);
                return firstResident;
            }
            else
            {
                return null;
            }
        }
        public int Count => residents.Count;
        public void SkipAhead(Resident resident, int positionsToSkip)
        {
            if (positionsToSkip < residents.Count && positionsToSkip >= 0)
            {
                residents.Insert(positionsToSkip, resident);
            }
            else
            {
                Enqueue(resident);
            }
        }
        public IEnumerable<Resident> GetResidents()
        {
            return residents.ToArray();
        }
    }
}
