namespace GrandPrix.Entities.Drivers
{
    public class Driver
    {
        protected Driver(string name, Car car, double fuelConsumptionPerKm)
        {
            this.Name = name;
            this.Car = car;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.TotalTime = 0.0;
        }
        public string Name { get; }
        public double TotalTime { get; private set; }
        public Car Car{get;}
        public double FuelConsumptionPerKm {get;}
        public virtual double Speed => (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmmount;
    }
}