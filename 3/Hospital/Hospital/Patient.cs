using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Patient : OnlineHospital
    {
        public new string Name { get; set; }
        public string Diagnosis { get; set; }
        
        public virtual void Display()
        {
            Console.WriteLine($" {Name} : диагноз {Diagnosis} ");
        }
    }
    public class TerapyPatient : Patient
    {
        public bool VisitTerapist { get; set; }

        public override void Display ()
        {
            base.Display ();
            if (VisitTerapist == true)
            {
                Console.WriteLine("Посетил терапевта: ");
            }
        }
    }

    public class NeurologyPatient : Patient
    {
        public bool VisitNeurology { get; set; }

        public override void Display()
        {
            base.Display();
            if (VisitNeurology == true)
            {
                Console.WriteLine("Посетил невролога: ");
            }
        }
    }
    public class OphtalmyPatient : Patient
    {
        public bool VisitOphtalmy { get; set; }

        public override void Display()
        {
            base.Display();
            if (VisitOphtalmy == true)
            {
                Console.WriteLine("Посетил офтальмолога: ");
            }
        }
    }
}
