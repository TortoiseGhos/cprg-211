using System;
using System.Configuration.Assemblies;

namespace employee {
    public class Employee {
        protected string id {get;set;}
        protected string name{get;set;}
        protected string address{get;set;}
        protected string phone{get;set;}
        protected string sin{get;set;}
        protected string dept{get;set;}
        protected string dob{get;set;}

        public Employee() {
            Console.WriteLine("employee");
        }

        public Employee(string ID, string Name, string Address, string tele, string Sin, string Dept, string Dob) {

            this.id = ID;
            this.name = Name;
            this.address = Address;
            this.phone = tele;
            this.sin = Sin;
            this.dept = Dept;
            this.dob = Dob;
        


        }

        public override string ToString() {
            return$"the id is {id} the name is {name} the add is {address} the tele is {phone} the sin is {sin} the dept is {dept} the dob is {dob}";
        }
    }
}