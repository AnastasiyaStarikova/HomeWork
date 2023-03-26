// See https://aka.ms/new-console-template for more information
//Спроектируем онлайн больницу.
//Создайте классы врачей и пациентов.
//У каждого врача и пациента должны быть набор свойств и методов (минимум 3 свойства и 2 метода)
//У врача должен быть метод взаимодействия с пациентом.
//В классе Program продемонстрируйте взаимодействие моделей врачей и пациентов. Проявите креатив)
//При проектировании у читывайте принципы SOLID и DRY. 

//Например: " У вас есть в вашей больнице 3 врача: терапевт, окулист и невролог,
//каждый из них имеет стаж, специализацию, имя, возраст и метод Cure,
//который принимает пациента и, например, меняет у пациента случайным образом статус на "Здоров" или "Болен".
//У пациента соотвественно в свойствах модели есть имя, возраст, адрес проживания и статус - здоров или болен".


using Hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3;

class Program
{
    static void Main(string[] args)
    {

        var T = new Terapy
        {
            Name = "Иванов И.И.",
            Age = 45,
            Speciality = "Терапевт",
            Experiense = 15,
        };

        var N = new Neurology
        {
            Name = "Петров П.П.",
            Age = 35,
            Speciality = "Невролог",
            Experiense = 10,
        };

        var O = new Ophtalmy
        {
            Name = "Соколов С.С.",
            Age = 25,
            Speciality = "Офтальмолог",
            Experiense = 2,
        };


        var p1 = new TerapyPatient 
        {
            Name = "Олег",
            Diagnosis = "- Здоров",
            VisitTerapist = true
        };

        var p2 = new OphtalmyPatient
        {
            Name = "Виктор",
            Diagnosis = "- Здоров",
            VisitOphtalmy = true
        };

        var p3 = new NeurologyPatient
        {
            Name = "Степан",
            Diagnosis = "- Здоров",
            VisitNeurology = true
        };

        var OH = new OnlineHospital
        {
            Name = "Информация о пациентах:"
        };

        OH.Display();

        p1.Display();
        T.Display();

        p2.Display();
        O.Display();

        p3.Display();
        N.Display ();
    }
}