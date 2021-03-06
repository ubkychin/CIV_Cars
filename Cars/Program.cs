﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars {
    class Program {
        static void Main(string[] args) {
            // Add a driver attribute to the Car -> Driver is of type Passenger
            // In the Main add a passenger named Anne Clements, I, 1970
            // add a driver named Dwayne Johnson, M, 1960
            // Make the car accelerate to 100

            // Print out:
            //   Car's Make, Model and Speed
            //   Driver's name, Sex and Age
            

            Car c1 = new Car(3500, "Nissan", "370Z");
            c1.Accelerate(5);

            Passenger zali = new Passenger("Zali", 'F', 2003);

            c1.AddPassenger(zali);


            Console.WriteLine(c1.Make);

            Console.ReadKey();
        }
    }

    public class Car {
        public int EngineCapacity;
        public string Make;
        public string Model;
        public int Speed;
        public List<Passenger> Passengers;

        public Car(int engineCapacity, string make, string model) {
            EngineCapacity = engineCapacity;
            Make = make;
            Model = model;
            Speed = 0;
            Passengers = new List<Passenger>();
        }

        public void Accelerate(int amount) {
            Speed += amount;
        }

        public void Decelerate(int amount) {
            if (Speed >= amount) {
                Speed -= amount;
            }
        }

        public void AddPassenger(Passenger p) {
            Passengers.Add(p);
        }
    }

    public class Passenger {
        public string Name;
        public char Sex;
        public int YearOfBirth;

        public Passenger(string name, char sex, int yearOfBirth) {
            Name = name;
            Sex = sex;
            YearOfBirth = yearOfBirth;
        }

        public int CalcAge(int CurrentYear) {
            return CurrentYear - YearOfBirth;
        }

        public string GetInfo() {
            return $"{Name} \t {Sex}";
        }
    }
}
