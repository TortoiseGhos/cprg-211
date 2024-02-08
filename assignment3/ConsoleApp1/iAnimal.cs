using System;

namespace animal {
    public interface IAnimal {
        
        public string name{get;set;}
        public string colour{get;set;}
        public string height{get;set;}
        public string Age{get;set;}
        public abstract void eat();
        public abstract string Cry();

    }

}