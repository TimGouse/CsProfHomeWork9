namespace CsProfHomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем и клонируем объекты каждого класса
            var vehicle = new Vehicle("Generic", "Model1");
            var clonedVehicle = vehicle.Clone();

            var car = new Car("Generic", "Model2", 4, "Petrol");
            var clonedCar = car.Clone();

            var electricCar = new ElectricCar("Generic", "Model3", 4, "Electric", 500, 300);
            var clonedElectricCar = electricCar.Clone();

            // Вывод информации о каждом клонированном объекте
            Console.WriteLine($"Cloned Vehicle: {clonedVehicle.Brand}, {clonedVehicle.Model}");
            Console.WriteLine($"Cloned Car: {clonedCar.Brand}, {clonedCar.Model}, {clonedCar.NumberOfDoors}, {clonedCar.EngineType}");
            Console.WriteLine($"Cloned ElectricCar: {clonedElectricCar.Brand}, {clonedElectricCar.Model}, {clonedElectricCar.NumberOfDoors}, {clonedElectricCar.EngineType}, {clonedElectricCar.BatteryCapacity}, {clonedElectricCar.RangePerCharge}");
        }
    }
}