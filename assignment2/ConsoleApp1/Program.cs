using System;
using System.Configuration.Assemblies;

namespace employee {
    class Program {
        static void Main(string[] args) {

            double percentage1 = 0.0;
            double percentage2 = 0.0;
            double percentage3 = 0.0;
            double highestPay = 10000000000000000000;
            double lowestPay = 0.0;

            
            string[] readFile = File.ReadAllLines("C:\\Users\\justa\\Coding\\c#\\classWork\\assignment2\\ConsoleApp1\\employees.txt");

            foreach(string a in readFile) {
            List<string> list = new List<string>();
                string[] data = a.Split(":");
            
                foreach(string b in data) {
                    list.Add(b);
                    
                }
                
                
                string first = list[0];
                string firstLetter = first.Substring(0,1);


                List<string> salary = new List<string> {"0", "1", "2", "3", "4"};
                List<string> wage = new List<string>{"5", "6", "7"};
                List<string> partTime = new List<string>{"8", "9"};

                if (salary.Contains(firstLetter)) {

                    double sal = Convert.ToDouble(list[7]);
                    

                    Salaried employee = new Salaried(list[0], list[1], list[2],list[3],list[4], list[6], list[5], sal);

                    Console.WriteLine(employee.ToString());

                    
                    
                    //lowest pay
                    if (highestPay > employee.GetPay()) {
                            highestPay = employee.GetPay();
                            
                    }                     
                    
                    percentage1 += 1;

                 } else if (wage.Contains(firstLetter)) {
                    double rate = Convert.ToDouble(list[7]);
                    double hours = Convert.ToDouble(list[8]);

                    Wages employee = new Wages(list[0], list[1], list[2],list[3],list[4], list[6], list[5], rate, hours);

                    Console.WriteLine(employee.ToString() + employee.GetPay());

                    
                    //highest pay
                    if (employee.GetPay() > lowestPay) {
                        lowestPay = employee.GetPay();
                    }
                    
                    percentage2 += 1;

                } else if (partTime.Contains(firstLetter)){

                    double rate = Convert.ToDouble(list[7]);
                    double hours = Convert.ToDouble(list[8]);

                    PartTime employee = new PartTime(list[0], list[1], list[2],list[3],list[4], list[6], list[5], rate, hours);
                    Console.WriteLine(employee.ToString());
                    percentage3 += 1;
                }
                
            
                
            }
            double fullPercent = percentage1 + percentage2 + percentage3;
            percentage1 = (percentage1/fullPercent) * 100;
            percentage2 = (percentage2/fullPercent) * 100;
            percentage3 = (percentage3/fullPercent) * 100;
            Console.WriteLine($"The percentage of salary workers is {percentage1} \n" + 
                            $"The percentage of wage workers is {percentage2}\n" + 
                              $"The Percentage of part time workers is {percentage3}\n" + 
                              $"lowest pay of salary employees {highestPay}\n" + 
                        $"highest weekly pay of wage employees {lowestPay}");
            
            }
            
            
            }



            
        


        }
    
