using System;

namespace HelloWorld
{
   class Program
   {
        enum Level
        {
            Low,
            Medium,
            High,
        }

        enum Months
        {
            January,   //0
            February,  //1
            March,     //2
            April=9,   //9
            May,       //4
            June,      //5
            July       //6
        }

        public string model;
        public string color;
        public int year;

        public Program(string modelName, string modelColor, int modelYear)
        {
            model = modelName;  
            color = modelColor;
            year = modelYear;   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("aaaa");


            Program Ford = new Program("Mustang", "red", 1969);
            Program Opel = new Program("Astra", "White", 2005);

            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            Console.WriteLine(Opel.color + " " + Opel.year + " " + Opel.model);

            Person person = new Person();
            person.Name = "Liam";
            Console.WriteLine(person.Name);

            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            //Animal myAnimal = new Animal();
            Pig myPig = new Pig();
            Dog myDog = new Dog();

            //myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Level myLevel = Level.Medium;
            Console.WriteLine(myLevel);

            int monthNum = (int)Months.April;
            Console.WriteLine(monthNum);

            Console.ReadKey();

        }


    }

    class Person
    {
        private string name = "aaa";

        public string Name
        { 
            get { return name; }
            set { name = "My name is: " + value; }
        }
    }

    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car: Vehicle
    {
        public string modelName = "Mustang"; 
    }

    abstract class Animal
    {
        /*
        Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

        Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).*/
        public abstract void animalSound();
        public virtual void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Note that you do not have to use the override keyword when implementing an interface:
    interface IAnimal 
    {
        void animalSound();// interface method (does not have a body)
    }

    class Pig: Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog: IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }


}

