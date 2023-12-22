namespace Park
{
    public class Vehicle
    {
        private double _size;
        private bool isTurnedOn = false;

        public double Size
        {
            get
            {
                Console.WriteLine($"Step 1.1 : [{GetType().Name}] size");
                return _size;
            }
        }

        public void TurnOn()
        {
            Console.WriteLine($"Step 1.4.2 : [{GetType().Name}] TurnOn");
            isTurnedOn=true;
        }

        public void TurnOff()
        {
            Console.WriteLine($"Step 1.4.3 : [{GetType().Name}] TurnOff");
            isTurnedOn=false;
        }
    }
}
