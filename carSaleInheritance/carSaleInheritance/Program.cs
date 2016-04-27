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
        public Boolean SoldVehicle;

        //static
        public static int numberOfVehicle;
        public static int totalValueSold = 0;
        public static int totalValueStock = 0;


        //Create a method  for Vehicle sold
        public void soldCar(bool isSoldVehicle, int price)
        {
            this.SoldVehicle = isSoldVehicle;
            this.price = price;
            if (isSoldVehicle)
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

        // Declare a Vehicle method in Vehicle class
        public void AddVehicle(string type, string name, string model, string color, int price)
        {
            this.type = type;
            this.name = name;
            this.model = model;
            this.color = color;
            this.price = price;
            this.SoldVehicle = false;
            Vehicle.numberOfVehicle++;
        }
             // Creating a new method for list car 
    public void ListVehicle()
        {
            Console.WriteLine("the details of the car are ");
            Console.WriteLine("Make and Model: {0} {1} {2}, {3} :", name, model, color, price);

            if (SoldVehicle)
            {
                Console.WriteLine("the car is sold");

            }
            else
            {
                Console.WriteLine("the car is unsold");

            }
            Console.WriteLine();
        }//end listcar method


    
    }// end of Vehicle class
    
   

    // inherited class car from Vehicle
    class Car : Vehicle
    {
        public static int numberOfCars;
        public void AddCar(string name, string model, string color, int price)
        {
            AddVehicle(type = "car", name, model, color, price);
            numberOfCars++;
        }


            }//end of car class






      

        

        public static void DisplayAllCars(List<Car> allcars)
        {
            foreach (Car item in allcars)
            {
                Console.WriteLine("The details of th car are:");
                Console.WriteLine("Make and model: {0} {1} {2}, {3}", item.name, item.model, item.color, item.price);



                if (item.SoldCar)
                {
                    Console.WriteLine("This car has been sold");

                }// end of if

                else
                {
                    Console.WriteLine("This car is unsold");

                }// end of else

                Console.WriteLine();

            }//end of if 
            Console.WriteLine(" The total  value of car sold is : £ {0}", Car.totalValueSold);
            Console.WriteLine("The total value of car stock is : £ {0}", Car.totalValueStock);
            Console.WriteLine();
        }// end of  DisplayAllCars method

    }//end car class

    class program
    {

        static void Main(string[] args)

        {

            Car.numberOfCar = 0;
            List<Car> allcars = new List<Car>();

            //Calling the car method 3 times to create new objects
            Car myCar = new Car();
            myCar.AddCar("Peugoet", " 206", "blue", 15000);
            allcars.Add(myCar);

            Car myCar1 = new Car();
            myCar1.AddCar("Citroen", "C3", "grey", 25000);
            allcars.Add(myCar1);

            Car myCar2 = new Car();
            myCar2.AddCar("Renault", "Espace", "green", 10000);
            allcars.Add(myCar2);

            //get the total value of the stock
            foreach (Car item in allcars)
            {
                Car.totalValueStock += item.price;
            }

            Car.DisplayAllCars(allcars);

            //calling the sold method 
            myCar.soldCar(true, 15000);
            myCar2.soldCar(true, 22000);
            // myCar1.soldCar(true, 25000);

            //display cars data
            Console.WriteLine("the name of car sold is", Car.numberOfCar);
            Car.DisplayAllCars(allcars);



        }//main

    }//end program class
}
        }
    }
}
