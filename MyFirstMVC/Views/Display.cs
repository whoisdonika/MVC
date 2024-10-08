using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Views
{
    public class Display
    {

        public double Amount { get; set; }
        public double Percent { get; set; }

        public double Tip { get; set; }
        public double TotalSum { get; set; }

        public void Input()
        {
            Console.Write("Enter the bill's sum : ");
            double sum = double.Parse(Console.ReadLine());
            this.Amount = sum;

            Console.Write("Enter the waiter's tip : ");
            double tip = double.Parse(Console.ReadLine());
            this.Percent = tip;
        }

        public void Output()
        {
            Console.WriteLine($"The waiter's tip is {this.Tip}lv");
            Console.WriteLine($"The total sum is {this.TotalSum}lv");
        }
        
    }
}
