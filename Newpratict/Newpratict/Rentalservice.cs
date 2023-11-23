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
            Console.WriteLine("Rentel Car");
            Console.WriteLine("Brand : " + car1.Brand);
            
        }
        public void Cr(Car car2)
        {
            Console.WriteLine("Rentel Car");
            Console.WriteLine("Brand : " + car2.Brand);
          
        }
    }
}
