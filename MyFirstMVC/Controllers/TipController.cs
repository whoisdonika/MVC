using MyFirstMVC.Models;
using MyFirstMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMVC.Controllers
{
    public class TipController
    {
       
        Display myDisplay = new Display();
        Tip myTip = new Tip();

        public TipController()
        {
            myDisplay.Input();
            myTip.Amount = myDisplay.Amount;
            myTip.Percent = myDisplay.Percent;
            myDisplay.Tip = myTip.CalculateTip();
            myDisplay.TotalSum = myTip.CalculateTotal();
            myDisplay.Output();
        }
    }
}
