using System;
using System.Configuration.Assemblies;

namespace employee {
    public class Wages : Employee{
        private double rate{get;set;}
        private double hours{get;set;}

        public Wages() {
            Console.WriteLine("wages");
        }

        public Wages(string ID, string Name, string Address, string tele, string Sin, string Dept, string Dob, double Rate, double hour) : base(ID, Name, Address, tele, Sin, Dept, Dob) {
            this.rate = Rate;
            this.hours = hour;
        }

        public double GetPay() {
            double overtime = 0.0;
            double hoursover = hours - 40;
            
            if (hours > 40) {
                overtime = rate * 1.5;

            }


            return rate * hours + overtime * hoursover;
        }

        public override string ToString()
        {
            return$"the wage for {name} is ";
        }
    }
}