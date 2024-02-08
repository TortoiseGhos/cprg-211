using System;
using System.Drawing;

namespace animal {
    public class Cat : Animal {
        public Cat() {

        }


        public Cat(string Name, string color, string age) : base(Name, color, age) {

        }

        public override void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }




    }

    public class catAnimal : IAnimal {

        public string name{get;set;}
        public string colour{get;set;}
        public string height{get;set;}
        public string Age{get;set;}
        
        public catAnimal(string n, string c, string h, string a) {

            this.name = n;
            this.colour = c;
            this.height = h;
            this.Age = a;



        }
        public void eat() {
            Console.WriteLine("Cats eat mice");
        }

        public string Cry() {
            return"Meow";
        }
    }
}
