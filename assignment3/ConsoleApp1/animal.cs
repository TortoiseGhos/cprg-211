using System;

namespace animal {

    public abstract class Animal {

        
        public string name{get;set;}
        public string colour{get;set;}
        public string Age{get;set;}

        public abstract void Eat();
        
        public Animal() {

        }
        public Animal(string Name, string color, string age) {
            this.name = Name;
            this.colour = color;
            this.Age = age;
        }


    }



}