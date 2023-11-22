using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsProfHomeWork9
{
    public class Vehicle : ICloneable, IMyCloneable<Vehicle>
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        object ICloneable.Clone() => Clone();

        public Vehicle Clone() => new Vehicle(Brand, Model);
    }

    // Класс Car, наследующийся от Vehicle
    public class Car : Vehicle, IMyCloneable<Car>
    {
        public int NumberOfDoors { get; set; }
        public string EngineType { get; set; }

        public Car(string brand, string model, int numberOfDoors, string engineType)
            : base(brand, model)
        {
            NumberOfDoors = numberOfDoors;
            EngineType = engineType;
        }

        public new Car Clone() => new Car(Brand, Model, NumberOfDoors, EngineType);
    }

    // Класс ElectricCar, наследующийся от Car
    public class ElectricCar : Car, IMyCloneable<ElectricCar>
    {
        public int BatteryCapacity { get; set; }
        public int RangePerCharge { get; set; }

        public ElectricCar(string brand, string model, int numberOfDoors, string engineType, int batteryCapacity, int rangePerCharge)
            : base(brand, model, numberOfDoors, engineType)
        {
            BatteryCapacity = batteryCapacity;
            RangePerCharge = rangePerCharge;
        }

        public new ElectricCar Clone() => new ElectricCar(Brand, Model, NumberOfDoors, EngineType, BatteryCapacity, RangePerCharge);
    }
}
