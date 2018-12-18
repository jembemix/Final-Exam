using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a Elevator variable named elevator1...
            Elevator elevator1 = new Elevator(2, 400);

            // adding first pessenger to the elevator1...
            elevator1.AddOccupant((new Passenger("A1", 180)), 0);

            // adding second passenger this one to elevator...
            elevator1.AddOccupant((new Passenger("A2", 220)), 1);

            // Checking if the elevator1 is over powered or not...
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();


            // Declare a Elevator variable named elevator2...
            Elevator elevator2 = new Elevator(3, 600);

            // adding the first passenger to the elevator2...
            elevator2.AddOccupant((new Passenger("A1", 200)), 0);

            // adding the second passenger this one to elevator...
            elevator2.AddOccupant((new Passenger("A2", 200)), 1);

            // adding the third this one to elevator...
            elevator2.AddOccupant((new Passenger("A3", 201)), 2);

            // Checking if the elevator2 is over max capacity or not...
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

        }
    }
}
