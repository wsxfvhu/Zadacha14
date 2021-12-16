using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            cat.Say();
            cat.ShowInfo();
            Dog dog = new Dog("Барбос");
            dog.Say();
            dog.ShowInfo();
            Console.ReadKey();
        }
        abstract class Animal
        {
            public abstract string Name { get; set; }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.WriteLine($"Имя: {Name}");
                Console.Write($"Говорит: ");
                Say();
            }
            public Animal(string name="zivotina")
            {
                Name = name;
            }

        }
        class Cat : Animal
        {
            string name;
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
            public Cat(string name)
            {
                Name = name;
            }
            public override void Say()
            {
                Console.WriteLine("Мяу-мяю");
            }
        }
        class Dog : Animal
        {
            string name;
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
            public Dog(string name)
            {
                Name = name;
            }
            public override void Say()
            {
                Console.WriteLine("Гав-гав");
            }
        }
    }
}
