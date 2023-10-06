namespace Challenges
{
    public class NumberOfWheels : IChallenge
{
    public void Execute()
    {
        var numberOfWheels = new Random().Next(1, 7);
        IVehicle vehicle = new Truck();

        switch (numberOfWheels)
        {
            case 1:
                vehicle = new Monocycle();
                break;
            case 2:
            case 3:
                vehicle = new Motorcycle();
                break;
            case 4:
                vehicle = new Car();
                break;
            case > 4:
                vehicle = new Truck();
                break;
        }

        Console.WriteLine($"Vehicle {vehicle.Name} has {vehicle.NumberOfWheels} wheels.");
    }

    public interface IVehicle
    {
        public int NumberOfWheels { get; }
        public string Name { get; }
    }

    public class Monocycle : IVehicle
    {
        public int NumberOfWheels => 1;
        public string Name => typeof(Monocycle).Name;
    }

    public class Motorcycle : IVehicle
    {
        public int NumberOfWheels => 2;
        public string Name => typeof(Motorcycle).Name;
    }

    public class Car : IVehicle
    {
        public int NumberOfWheels => 4;
        public string Name => typeof(Car).Name;
    }

    public class Truck : IVehicle
    {
        public int NumberOfWheels => 6;
        public string Name => typeof(Truck).Name;
    }
}
}