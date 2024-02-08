using System;

namespace animal {
    public class Dog : Animal{
        public Dog() {

        }
        public Dog(string Name, string color, string age) : base (Name, color, age) {

        }

        public override void Eat() {
            Console.WriteLine("Dogs eat Meat");
        }

        



    }

    public class dogAnimal : IAnimal {
        
        public string name{get;set;}
        public string colour{get;set;}
        public string height{get;set;}
        public string Age{get;set;}

        public dogAnimal(string n, string c, string h, string a) {

            this.name = n;
            this.colour = c;
            this.height = h;
            this.Age = a;



        }
        
        public void eat() {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry() {
            return"Woof";
        }

    }
}