using System.Net.NetworkInformation;

namespace Park
{
    public class ParkingLot
    {
        List<Vehicle> parkedVehicles = new List<Vehicle>();
        List<Valet> valets = new List<Valet>();

        public ParkingLot()
        {
           
        }

        public void Park(Vehicle vehicle)
        {
            Console.WriteLine($"Step 1 : [{GetType().Name}] will park the vehicle");
            double _sizeVehicle = vehicle.Size;
            if (!IsAlreadyParked(vehicle))
            {
                Valet valet = ChooseValet();
                valet.Drive(vehicle);
                AddVehicleParked(vehicle);
            }
        }

        private Valet ChooseValet()
        {
            Console.WriteLine($"Step 1.3 : [{GetType().Name}] ChooseValet");
            return new Valet();
        }

        public bool IsAlreadyParked(Vehicle vehicle)
        {
            Console.WriteLine($"Step 1.2 : [{GetType().Name}] vehicle already parked ?");
            return parkedVehicles.Contains(vehicle);
        }

        private void AddVehicleParked(Vehicle vehicle)
        {
            Console.WriteLine($"Step 1.5 : [{GetType().Name}] put vehicle into parkedVehicle");
            parkedVehicles.Add(vehicle);
        }
    }
}
