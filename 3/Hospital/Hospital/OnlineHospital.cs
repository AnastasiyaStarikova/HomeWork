using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class OnlineHospital
    {
        public string Name { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($" {Name} ");
        }
    }
}
