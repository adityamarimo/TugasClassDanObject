using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);

            if (OnDuty)
                Console.WriteLine("On Dutty : Yes");
            else
                Console.WriteLine("On Dutty : No");

            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);
            Console.WriteLine();
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} Sedang Menjemput Penumpang",DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Selesai Menjemput Penumpang",DriverName);
        }
    }
}
