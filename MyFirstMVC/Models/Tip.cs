using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class Tip
    {
		private double amount;

		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		private double percent;

		public double Percent
		{
			get { return percent; }
			set
			{
				if(value > 1)
				{
					this.percent = value / 100.0;
				}
				else
				{
					this.percent = value;
				}
			}
		}

		public double CalculateTip()
		{
			return (this.Amount * this.Percent);
		}

		public double CalculateTotal()
		{
			return this.Amount + this.CalculateTip();
		}

        public Tip()
        {
				
        }

		public Tip(double amount, double percent)
		{
			this.Amount = amount;
			this.Percent = percent;
		}
    }
}
