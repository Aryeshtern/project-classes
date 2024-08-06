using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_classes
{
    public class Vehicle
    {
        protected string Model = string.Empty;

        private int EngineCapacity = 180;

        public int GetEngineCapacity()
        {
            return EngineCapacity;
        }


    }

    public class Car : Vehicle
    {
        public int NumberOfDoors;
        public Car(string model, int numberOfDoors)
        {
            Model = model;
            NumberOfDoors = numberOfDoors;
        }

        public string GetDetials()
        {
            return $"Model:{Model}, engineCapacity{GetEngineCapacity()}, number of doors: {NumberOfDoors}";
        }
    }


    
}
