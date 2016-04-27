using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSaleInheritance
{
    class Vehicle
    {
        // non static field
        public string type;
        public string name;
        public string model;
        public string color;
        public int price;
        public Boolean Sold;

        // Declare a Vehicle method in Vehicle class
        public void AddVehicle(string type, string name, string model, string color, int price)
        {
            this.type = type;
            this.name = name;
            this.model = model;
            this.color = color;
            this.price = price;
            this.Sold = false;
            Vehicle.numberOfVehicle++;
        }

        //static
        public static int numberOfVehicle;
        public static int totalValueSold = 0;
        public static int totalValueStock = 0;


        //Create a method  for Vehicle sold
        public void sold(bool isSold, int price)
        {
            this.Sold = isSold;
            this.price = price;
            if (isSold)
            {
                totalValueSold += price;
                totalValueStock -= price;
            }
            else
            {
                totalValueSold -= price;
                totalValueStock += price;
            }

            Vehicle.numberOfVehicle--;
        }


        // Creating a new method for list Vehicler
        public void ListVehicle()
        {
            Console.WriteLine("the details of the car are ");
            Console.WriteLine("Make and Model: {0} {1} {2}, {3} :", name, model, color, price);

            if (Sold)
            {
                Console.WriteLine("the car is sold");

            }
            else
            {
                Console.WriteLine("the car is unsold");

            }
            Console.WriteLine();
        }
        public static void DisplayAllVehicle(List<Vehicle> allVehicles)
        {
            foreach (Vehicle item in allVehicles)
            {
                Console.WriteLine("The details of th Vehicle are:");
                Console.WriteLine("Make and model: {0} {1} {2}, {3}", item.name, item.model, item.color, item.price);

                if (item.Sold)
                {
                    Console.WriteLine("This Vehicle has been sold");
                }

                else
                {
                    Console.WriteLine("This Vehicle is unsold");

                }// end of else

                Console.WriteLine();

            }//end of if 
            Console.WriteLine(" The total  value of Vehicle sold is : £ {0}", Vehicle.totalValueSold);
            Console.WriteLine("The total value of Vehicle stock is : £ {0}", Vehicle.totalValueStock);
            Console.WriteLine();
        }// end of  DisplayAllCars method

    }//end listcar method

    // inherited class car from Vehicle
    class Car : Vehicle
    {
        public static int numberOfCars;
        public void AddCar(string name, string model, string color, int price)
        {
            AddVehicle(type = "car", name, model, color, price);
            numberOfCars++;
        }
        public void Soldcar(bool isSold, int price)
        {
            sold(isSold, price);
            numberOfCars--;
        }
    }//end car class

    class Motorcycle : Vehicle
    {// beginning of Motorcycle
        public static int numberOfBike;
        public void AddMotorbike(string name, string model, string color, int price)
        {
            AddVehicle(type = "Motorbike", name, model, color, price);
            numberOfBike++;
        }
        public void SoldMotorbike(bool isSold, int price)
        {
            sold(isSold, price);
            numberOfBike--;
        }
    }//end of Motorcycle class
    class program
    {
        static void Main(string[] args)


            Car.numberOfCars = 0;
            Motorcycle.numberOfBike = 0;

               //Calling the car method 3 times to create new objects
               List<Vehicle> allVehicles = new List<Vehicle>();

        Car myCar = new Car();
        myCar.AddCar("Peugoet", " 206", "blue", 15000);
                allVehicles.Add(myCar);

                Car myCar1 = new Car();
        myCar1.AddCar("Citroen", "C3", "grey", 25000);
                allVehicles.Add(myCar1);

                Car myCar2 = new Car();
        myCar2.AddCar("Renault", "Espace", "green", 10000);
                allVehicles.Add(myCar2);
            
                Motorcycle MyBike = new Motorcycle();
        MyBike.AddMotorbike("Triumph", "Tiger 800", 10000);
                allVehicles.Add(MyBike);

                Motorcycle Mybike2 = new Motorcycle();
        MyBike2.AddMotorbike("Vespa", "Sprint 150", 2500);
                allVehicles.Add(MyBike2);

             Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", Motorcycle.numberOfBike);
            Console.WriteLine();
       
Vehicle.DisplayAllVehicles(allVehicles);
                        //calling the sold method 
            myCar.soldCar(true, 15000);
            myBike2.soldBike(true, 22000);

            Console.WriteLine("Total number of cars in sold is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorbikes in sold is: {0}", Motorcycle.numberOfBike);
            Console.WriteLine();
            Vehicle.DisplayAllVehicle(allVehicles);
            //get the total value of the stock
            foreach (Vehicle item in allVehicles)
            {
                Vehicle.totalValueStock += item.price;
            }

    Vehicle.DisplayAllVehicle(allVehicle);


    //display cars data
    Console.WriteLine("the name of car sold is", numberOfVehicle);
       
            Vehicle.DisplayAllVehicle(allVehicle);


            }//end of Vehicle 
  //end of program
    
