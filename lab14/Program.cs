using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            cat.ShowInfo();
            cat.Say();
            dog.ShowInfo();
            dog.Say();
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; set; }
        
        public abstract void Say();
        
        public void ShowInfo()
        {
            Console.Write("Меня зовут {0}, ", Name);
        }
    }

    class Cat : Animal
    {
        string name = "Рыжик";        

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override void Say()
        {
            Console.WriteLine("мяу");
        }

    }
    class Dog : Animal
    {
        string name = "Бобик";

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override void Say()
        {
            Console.WriteLine("гав");
        }

    }
}
