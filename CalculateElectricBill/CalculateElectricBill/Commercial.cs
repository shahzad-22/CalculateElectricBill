using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateElectricBill
{
    class Commercial : ElectricBill
    {
        double firstHundred = (100 * 8);
        double secondHundred = (100 * 21);
        public void BillForCommercial() {

            Console.WriteLine("Welcome to Commercial Bill Calculate");
            Console.WriteLine("Enter your Total Units");
            double TotalUnitsConsume = Convert.ToDouble(Console.ReadLine());
            if (TotalUnitsConsume <= 100)
            {
                TotalUnitsConsume = TotalUnitsConsume * 8;
                Tax = TotalUnitsConsume * 17 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax;
                Console.WriteLine("your Total Tax is = " + Tax + "%");
                Console.WriteLine(" your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            else if (TotalUnitsConsume > 100 && TotalUnitsConsume <= 200)
            {
                TotalUnitsConsume = firstHundred + (TotalUnitsConsume - 100) * 21;
                Tax = TotalUnitsConsume * 17 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax;
                Console.WriteLine(" your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            else if (TotalUnitsConsume > 200 && TotalUnitsConsume <= 500)
            {
                TotalUnitsConsume = firstHundred + secondHundred + (TotalUnitsConsume - 300) * 23;
                Tax = TotalUnitsConsume * 17 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax;
                Console.WriteLine("your Total Tax is = " + Tax + "%");
                Console.WriteLine("  your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            else if (TotalUnitsConsume > 500)
            {
                TotalUnitsConsume = firstHundred + secondHundred + (TotalUnitsConsume - 300) * 79;
                Tax = TotalUnitsConsume * 17 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax;
                Console.WriteLine("your Total Tax is = " + Tax + "%" );
                Console.WriteLine("  your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            Console.ReadKey();
        
        
        }
    }
}
