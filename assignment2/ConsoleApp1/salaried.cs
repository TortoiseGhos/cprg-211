using System;
using System.Configuration.Assemblies;

namespace employee {
    public class Salaried : Employee {
        private double salary{get;set;}

        public Salaried() {
            Console.WriteLine("salaried");
        }

        public Salaried(string ID, string Name, string Address, string tele, string Sin, string Dept, string Dob, double Salary) : base(ID, Name, Address, tele, Sin, Dept, Dob) {
            this.salary = Salary;
            
            

            

        }

        public double GetPay() {
            return salary;
        }

        public override string ToString()
        {
            return$"The salary for {name} is {salary}";
        }
    }
}