using System;
using System.Configuration.Assemblies;

namespace employee
{
    public class PartTime : Employee {
        private double rate{get;set;}
        private double hours{get;set;}

        public PartTime() {
            Console.WriteLine("parttime");
        }

        public PartTime(string ID, string Name, string Address, string tele, string Sin, string Dept, string Dob, double Rate, double Hours) : base(ID, Name, Address, tele, Sin, Dept, Dob) {
            this.rate = Rate;
            this.hours = Hours;
        }

        public double GetPay() {
            return rate * hours;
        }

        public override string ToString()
        {
            return$"The pay for {name} is {hours * rate}";
        }
    }
}