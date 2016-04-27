using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Car
    {
        // non static
        public string name;
        public string model;
        public string color;
        public int price;
        //static
        public static int numberofCar;


    }

    class program
    {
       
        static void Main(string[] args)
        {
            // beginning of car object
            Car myCar = new Car();

            myCar.name = "Peugoet";
            myCar.model = "206";
            myCar.color = "blue";
            myCar.price = 15000;
            //Creating a second obejct to add car 
            Car myCar1 = new Car();
            myCar1.name = "Citroen";
            myCar1.model = "C3";
            myCar1.color = "grey";
            myCar1.price =25000;
            //Creating a third obejct to add car 
            Car myCar2 = new Car();
            myCar2.name = "Renault";
            myCar2.model = "Espace";
            myCar2.color = "green";
            myCar2.price = 10000;
//number of car static : use name of class 
            Car.numberofCar = 3;

            Console.WriteLine(" The number of car sold is"  + Car.numberofCar);
            Console.WriteLine("Your car descritpion is");
            Console.WriteLine("The Car mame is " + " " + myCar.name + " " + " model:" + myCar.model + "color:" + " " + myCar.color + "price: " + " " + "£" + myCar.price);
            Console.WriteLine("Your car descritpion is");
            Console.WriteLine("The Car mame is " + " "+ myCar1.name + " " + " model:" + myCar.model + "color:" + " " + myCar.color +"price: " + " "+ "£" + myCar.price);
            Console.WriteLine("Your car descritpion is");
            Console.WriteLine("The Car mame is " + " " + myCar2.name + " " + " model:" + myCar.model + "color:" + " " + myCar.color + "price: " + " " + "£" + myCar.price);
            Console.ReadLine();
        }//main



        }//end of class program


    }//end of namespace
 
