using System;

namespace animal {
    class Program {
        static void Main(string[] args) {
            List<Animal> animals = new List<Animal>();
            Dog dog1 = new Dog("flint", "black", "12");
            animals.Add(dog1);
            Cat cat = new Cat("fluffs", "white", "1");
            animals.Add(cat);
            Dog dog2 = new Dog("sparky", "mixed", "12");
            animals.Add(dog2);
            Cat cat2 = new Cat("mr.mittens", "black", "3");
            animals.Add(cat2);


            foreach (Animal a in animals){
                Console.WriteLine(a.name);
            }
            



            Console.WriteLine("what is the dogs name");
            string dogName = Console.ReadLine();
            Console.WriteLine("what is the dogs color");
            string dogColor = Console.ReadLine();
            Console.WriteLine("what is the dogs height");
            string dogHeight = Console.ReadLine();
            Console.WriteLine("what is the dogs age");
            string dogAge = Console.ReadLine();

            dogAnimal dog = new dogAnimal(dogName, dogColor, dogHeight, dogAge);
            dog.eat();
            Console.WriteLine(dog.Cry());

            Console.WriteLine("What is the cats name");
            string catName = Console.ReadLine();
            Console.WriteLine("What is the cats color");
            string catColor = Console.ReadLine();
            Console.WriteLine("what is the cats height");
            string catHeight = Console.ReadLine();
            Console.WriteLine("whats is the cats age");
            string catAge = Console.ReadLine();

            catAnimal cat1 = new catAnimal(catName, catColor, catHeight, catAge);
            cat1.eat();
            Console.WriteLine(cat1.Cry());
            



        }
    }
}