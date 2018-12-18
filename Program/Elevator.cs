using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;
        private double EWeight = 0;

        public Elevator(int maxOccupants, double maxWeight)
        {
            MaxWeight = maxWeight;
            Occupants = new Passenger[maxOccupants];
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            for(int i = 0; i < Occupants.Length; i++)
            {
                EWeight += Occupants[i].GetWeight();
            }

            return EWeight;
        }

        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight) { return true; }
            else { return false; }
        }
    }
}
