using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Doctor : OnlineHospital
    {
        public new string Name { get; set; }
        public string Speciality { get; set; }
        public int Experiense { get; set; }
        public int Age { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($" ФИО врача - {Name} : возраст - {Age}, стаж - {Experiense}, специальность - {Speciality}");

        }
    }
     public class Terapy : Doctor
    {
        public bool WorksInHospital { get; set; }

        public override void Display ()
        {
            base.Display();
            if (WorksInHospital == true)
            {
                Console.WriteLine("Терапевт работает в online больнице");
            }
        }
    }
    public class Neurology : Doctor
    {
        public bool WorksInHospital { get; set; }

        public override void Display()
        {
            base.Display();
            if (WorksInHospital == true)
            {
                Console.WriteLine("Невролог работает в online больнице");
            }
        }
    }
    public class Ophtalmy : Doctor
    {
        public bool WorksInHospital { get; set; }

        public override void Display()
        {
            base.Display();
            if (WorksInHospital == true)
            {
                Console.WriteLine("Офтальмолог работает в online больнице");
            }
        }
    } 

}
