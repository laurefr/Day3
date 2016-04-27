using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Car
    {
        // non static field
        public string name;
        public string model;
        public string color;
        public int price;
        public Boolean SoldCar;
        
        //static
        public static int numberOfCar;
        public static int totalValueSold = 0;
        public static int totalValueStock = 0;

        // Declare a car method in car class
        public void AddCar(string name, string model, string color, int price)
        {
            this.name = name;
            this.model = model;
            this.color = color;
            this.price = price;
            this.SoldCar = false;
            Car.numberOfCar++;
        }
        //Create a method  for sold car 
        public void soldCar(bool isSoldCar, int price)
        {
            this.SoldCar = isSoldCar;
            this.price = price;
            if(isSoldCar)
            {
                totalValueSold += price;
                totalValueStock -= price;
            }
            else
            {
                totalValueSold -= price;
                totalValueStock += price;
            }
            
            Car.numberOfCar--;
        }

        // Creating a new method for list car 
        public void ListCar()
        {
            Console.WriteLine("the details of the car are ");
            Console.WriteLine("Make and Model: {0} {1} {2}, {3} :", name, model, color, price);

            if (SoldCar)
            {
                Console.WriteLine("the car is sold");
                
            }
            else
            {
                Console.WriteLine("the car is unsold");
               
            }
            Console.WriteLine();
                      

        }//end listcar method

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
            Console.WriteLine( " The total  value of car sold is : £ {0}", Car.totalValueSold);
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







 
