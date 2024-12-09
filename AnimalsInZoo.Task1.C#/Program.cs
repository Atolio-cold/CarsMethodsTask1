using System;
using System.Collections;
using System.ComponentModel;

namespace AnimalsInZoo
{
    public interface IZooAnimal
    {
        void MakeSound();
        void Describe();
    }

    public class Lion : IZooAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
        public void Describe()
        {
            Console.WriteLine("This is a lion. It is the king of the jungle.");
        }
    }
    public class Elephant : IZooAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Trumpet!");
        }
        public void Describe()
        {
            Console.WriteLine("This is an elephant. It is the largest land animal.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<IZooAnimal> listofAnimal = new List<IZooAnimal>();
            listofAnimal.Add(new Lion());
            listofAnimal.Add(new Elephant());




            foreach (IZooAnimal animal in listofAnimal)
            {
                animal.MakeSound();
                animal.Describe();

            }
        }
    }
}