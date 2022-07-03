using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateElectricBill
{
    class Residential : ElectricBill
    {
        
        public void BillForResidential()
        {

            Console.WriteLine("Welcome to Residential Bill Calculate");
            Console.WriteLine("Enter your Total Units");
            double TotalUnitsConsume = Convert.ToDouble(Console.ReadLine());
            if (TotalUnitsConsume <= 100)
            {
                TotalUnitsConsume = TotalUnitsConsume * 5;
                Tax = TotalUnitsConsume * 13 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax;
                Console.WriteLine("your Total Tax is = " + Tax + "%");
                Console.WriteLine("your  Bill Between 101 to 200 residenstial Units your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            else if (TotalUnitsConsume > 100 && TotalUnitsConsume <= 200)
            {
                TotalUnitsConsume = (100 * 5) + (TotalUnitsConsume - 100) * 17;
                Tax = TotalUnitsConsume * 13 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax; 
                Console.WriteLine("your Total Tax is = " + Tax + "%");
                Console.WriteLine("  your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            else if (TotalUnitsConsume > 200 && TotalUnitsConsume <= 500)
            {
                TotalUnitsConsume = (100 * 5) + (100 * 17) + (TotalUnitsConsume - 300) * 23;
                Tax = TotalUnitsConsume * 13 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax;
                Console.WriteLine("your Total Tax is = " + Tax + "%");
                Console.WriteLine("your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            else if (TotalUnitsConsume > 500)
            {
                TotalUnitsConsume = (100 * 5) + (100 * 17) + (TotalUnitsConsume - 300) * 69;
                Tax = TotalUnitsConsume * 13 / 100;
                TotalUnitsConsume = TotalUnitsConsume + Tax;
                Console.WriteLine("your Total Tax is = " + Tax + "%");
                Console.WriteLine("your Total Amout of your Bills is = " + TotalUnitsConsume);

            }
            Console.ReadKey();

        
        }
    }
}
