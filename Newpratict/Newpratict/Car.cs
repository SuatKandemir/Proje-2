using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newpratict
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Fuel { get; set; }

        public void Drive()
        {
            Fuel -= 5;

        }
        public void Addfuel()
        {
            Fuel = 20;
        } 
        public void Addfuel(int lt) 
        {
            Fuel += lt;
        }
    }
    
}
