
namespace Program
{
    class Passenger
    {
        private string Name;
        private double Weight;

        // Constructor...
        public Passenger(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        
        // this will return the name of the passenger...
        public string GetName()
        {
            return Name;
        }

        // this will return the weight of the passenger...
        public double GetWeight()
        {
            return Weight;
        }
    }

}
