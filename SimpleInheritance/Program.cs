using System;
using System.Drawing;

namespace Inheritance
{
    class Animal
    {
        public string name;
        public string species;
        public string color;
   

        public Animal()
        {
            name = "";
            species = "";
            color = "";

        }
        
        public Animal(string name, string species, string color)
        {
            this.name = name;
            this.species = species;
            this.color = color;
           
        }

        public void display()
        {
            Console.WriteLine($"I am an animal.");
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am a {species}");
            Console.WriteLine($"I am the color {color}");
        }

    }

    // derived class of Animal 
    class Mouse : Animal
    {
        public int age;
        public int weight;
        public Mouse()
            : base()  // calls the Animal class constructor
        {
            age = 0;
            weight = 0;
        }
        public Mouse(string name, string species, string color, int age, int weight)
           : base(name, species, color)
        {
            this.age = age;
            this.weight = weight;
        }
        public void getName()
        {
            Console.WriteLine($"My name is {name}");
        }

        public void sound()
        {
            Console.WriteLine($"I like to squeak");
        }

        public void food()
        { 
            Console.WriteLine($"I like to eat cheese");
        }
        public void getAge()
        {
            Console.WriteLine($"I am {age} years old");
        }
        public void getWeight()
        {
            Console.WriteLine($"I weigh {weight} pounds");
        }
       
    }

    class Cat : Animal
    {
        public int age;
        public int weight;
        public Cat()
            : base()  // calls the Animal class constructor
        {
            age = 0;
            weight = 0;
        }
        public Cat(string name, string species, string color, int age, int weight)
           : base(name, species, color)
        {
            this.age = age;
            this.weight = weight;
        }
        public void getName()
        {
            Console.WriteLine($"My name is {name}");
        }

        public void sound()
        {
            Console.WriteLine($"I like to meow");
        }

        public void food()
        {
            Console.WriteLine($"I like to eat fish");
        }
        public void getAge()
        {
            Console.WriteLine($"I am {age} years old");
        }
        public void getWeight()
        {
            Console.WriteLine($"I weigh {weight} pounds");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // class 2 object
            Mouse myMouse = new Mouse();

            myMouse.name = "Stuart Little";
            myMouse.species = "mouse";
            myMouse.color = "white";
            myMouse.display();
            
            myMouse.age = 3;
            myMouse.weight = 1;
            myMouse.sound();
            myMouse.food();
            myMouse.getAge();
            myMouse.getWeight();
            Console.WriteLine(); //break


            Mouse mickey = new Mouse("Mickey", "Mouse", "Black", 50, 5);
            mickey.display();
            mickey.sound();
            mickey.food();
            mickey.getAge();
            mickey.getWeight();
            Console.WriteLine(); //break

            // class 3 object

            Cat myCat = new Cat();

            myCat.name = "Tom";
            myCat.species = "cat";
            myCat.color = "gray";
            myCat.display();


            myCat.age = 3;
            myCat.weight = 10;
            myCat.sound();
            myCat.food();
            myCat.getAge();
            myCat.getWeight();
            Console.WriteLine(); //break

            Cat Felix = new Cat("Felix", "Cat", "Black", 20, 8);
            Felix.display();
            Felix.sound();
            Felix.food();
            Felix.getAge();
            Felix.getWeight();

            Console.ReadLine();
        }

    }
}