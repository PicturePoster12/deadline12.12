using System;
namespace DopZadanie
{
    public class Problem
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public Problem(int number, string description)
        {
            Number = number;
            Description = description;
        }
    }
}
