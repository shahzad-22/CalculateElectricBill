using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateElectricBill
{
    class ElectricBill
    {
        public double TotalUnitsConsume { get; set; }
        public double TotalUnits { get; set; }
        public double Tax { get; set; }
       
        static void Main(string[] args)
        {
           
            ElectricBill electricBill = new ElectricBill();
            Commercial Commercial = new Commercial();
            Residential Residential = new Residential();
            int input;
            bool flag=true;
            while (flag) {
                Console.WriteLine("Choise the following options");
                Console.WriteLine("1: For Commercial");
                Console.WriteLine("2: For Rediential");
                Console.WriteLine("3: For Exit");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input) { 
                    case 1:

                        Commercial.BillForCommercial();
                        break;
                    case 2:
                        Residential.BillForResidential();
                        break;
                    case 3:
                        flag = false;
                        break;
                
                }
            
            }
           
            }
           
          
        }
         
    

}

