namespace Park
{
    public class Valet
    {
        private bool _available = true;

        public bool Available
        {
            get
            {
                Console.WriteLine($"Step 1.4.1 : [{GetType().Name}] Available");
                return _available;
            }
        }

        public void Drive (Vehicle vehicle)
        {
            if (Available)
            {
                vehicle.TurnOn();
                vehicle.TurnOff();
            }
        }
    }
}
