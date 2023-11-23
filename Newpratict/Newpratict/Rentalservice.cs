using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Newpratict
{
    public class Rentalservice
    {
        public void CarRental(Car car1)
        {
            Console.WriteLine("Kiralanan araç");
            Console.WriteLine("Marka : " + car1.Brand);
            
        }
        public void Cr(Car car2)
        {
            Console.WriteLine("Kiralanan araç");
            Console.WriteLine("Marka : " + car2.Brand);
          
        }
    }
}
