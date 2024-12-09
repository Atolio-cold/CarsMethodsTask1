using System;
using System.Collections;
using System.ComponentModel;


namespace AnimalsInZoo
{
    public interface IZooAnimal
    {
        void MakeSound();
        void Describe();
        public string GetName();
        public string GetHabitat();
        public void Feed(string food);

    }

    public class Lion : IZooAnimal
    {
        string favoriteFood = "meat";
        public string GetName()
        {
            return "Lion";
        }

        public string GetHabitat()
        {
            return "Savannah";
        }

        public void Feed(string food)
        {
            if (food == favoriteFood)
            {
                Console.WriteLine($"{GetName()} happily eats {food}.");

            }
            else
            {
                Console.WriteLine($"{GetName()} doesn't eat {food}.");

            }
        }

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
        string favoriteFood = "grass";

        public string GetHabitat()
        {
            return "Savannah";
        }

        public string GetName()
        {
            return "Elephant";
        }

        public void Feed(string food)
        {
            if (food == favoriteFood)
            {
                Console.WriteLine($"{GetName()} happily eats {food}.");

            }
            else
            {
                Console.WriteLine($"{GetName()} doesn't eat {food}.");

            }
        }
        public void MakeSound()
        {
            Console.WriteLine("Trumpet!");
        }
        public void Describe()
        {
            Console.WriteLine("This is an elephant. It is the largest land animal.");
        }
    }

    public class Tiger : IZooAnimal
    {
        string favoriteFood = "meat";

        public string GetHabitat()
        {
            return "ZOO";
        }

        public string GetName()
        {
            return "Tiger";
        }
        public void Feed(string food)
        {
            if (food == favoriteFood)
            {
                Console.WriteLine($"{GetName()} happily eats {food}.");

            }
            else
            {
                Console.WriteLine($"{GetName()} doesn't eat {food}.");

            }
        }

        public void MakeSound()
        {
            Console.WriteLine("Wrrr!");
        }
        public void Describe()
        {
            Console.WriteLine("This is an Tiger.It is one of the fastest land animals.");
        }

    }
    public class Monkey : IZooAnimal
    {
        string favoriteFood = "bananas";

        public string GetHabitat()
        {
            return "Forest";
        }
        public void Feed(string food)
        {
            if (food == favoriteFood)
            {
                Console.WriteLine($"{GetName()} happily eats {food}.");

            }
            else
            {
                Console.WriteLine($"{GetName()} doesn't eat {food}.");

            }
        }
        public string GetName()
        {
            return "Monkey";
        }

        public void MakeSound()
        {
            Console.WriteLine("Uhuhuh!");
        }
        public void Describe()
        {
            Console.WriteLine("This is a Monkey. It is a funny and clever animal.");
        }

    }
    public class Program
    {
        public static void Main()
        {
            List<IZooAnimal> listofAnimal = new List<IZooAnimal>();
            listofAnimal.Add(new Lion());
            listofAnimal.Add(new Elephant());
            listofAnimal.Add(new Tiger());
            listofAnimal.Add(new Monkey());

            Dictionary<string, List<IZooAnimal>> habitatGroups = new Dictionary<string, List<IZooAnimal>>();

            foreach (IZooAnimal animal in listofAnimal)
            {
                string habitat = animal.GetHabitat();
                if (!habitatGroups.ContainsKey(habitat))
                {
                    habitatGroups[habitat] = new List<IZooAnimal>();
                }
                habitatGroups[habitat].Add(animal);
            }


            foreach (var habitatGroup in habitatGroups)
            {
                Console.WriteLine($"Habitat: {habitatGroup.Key}");
                foreach (var animal in habitatGroup.Value)
                {
                    Console.WriteLine($" - {animal.GetName()}");
                }
            }
            Console.WriteLine();

            foreach (IZooAnimal animal in listofAnimal)
            {
                Console.WriteLine($"Feeding {animal.GetName()}:");
                animal.Feed("meat");
                animal.Feed("grass");
                animal.Feed("bananas");
                Console.WriteLine();
            }


            foreach (IZooAnimal animal in listofAnimal)
            {
                Console.WriteLine($"Animal: {animal.GetName()}");
                animal.Describe();
                animal.MakeSound();
                Console.WriteLine();
            }

        }
    }
}

