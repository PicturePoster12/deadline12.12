using System;
namespace DopZadanie
{
    public class Resident
    {
        public string Name { get; set; }
        public int PassportNumber { get; set; }
        public Problem Problem { get; set; }
        public int Scandalousness { get; set; }
        public bool IsSmart { get; set; }
        public Resident(string name, int passportNumber, Problem problem, int scandalousness, bool isSmart)
        {
            Name = name;
            PassportNumber = passportNumber;
            Problem = problem;
            Scandalousness = scandalousness;
            IsSmart = isSmart;
        }
    }
}
