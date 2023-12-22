using Park;

namespace Palace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Palace !");

            Console.WriteLine("Start of sequence : Regular Park");

            ParkingLot parkingLot = new ParkingLot();
            Vehicle vehicle = new Vehicle();
            parkingLot.Park(vehicle);

            Console.WriteLine("End of sequence : Regular Park");
        }
    }
}
