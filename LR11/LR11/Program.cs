using System;
using System.Collections.Generic;

namespace LR11
{
    class Program
    {
        static void Main(string[] args)
        {
            var sto = new STO();

            var rozval = new STo(sto.Rozval_shozdeny);

           

            var painted = new STo(sto.Painted);
           

            var MasloYest = new STo(sto.MasloYest);
           

            var Teh_oglad = new STo(sto.Teh_oglad);

            var Change_kolesa = new STo(sto.Change_kolesa);

            var remont_kuzova = new STo(sto.remont_kuzova);

            Disply disply= new Disply(sto.DIsplay) ;


            var combineRozval_Painted = rozval + painted;
            combineRozval_Painted(true);

            var combineMasloYest_Teh_oglad = MasloYest + Teh_oglad;
            combineMasloYest_Teh_oglad(false);

            remont_kuzova(true);
            Change_kolesa(true);


            disply();
            Console.WriteLine("----------------");

            var sto2 = new STO();

            var rozval2 = new STo(sto2.Rozval_shozdeny);

            var MasloYest2 = new STo(sto2.MasloYest);

            var painted2 = new STo(sto2.Painted);

            var Teh_oglad2 = new STo(sto2.Teh_oglad);

            var Change_koles2a = new STo(sto2.Change_kolesa);

            var remont_kuzova2 = new STo(sto2.remont_kuzova);

            Disply disply2 = new Disply(sto2.DIsplay);


            var combineRozval_Painted2 = rozval2 + painted2;
            combineRozval_Painted2(true);

            var combineMasloYest_Teh_oglad2 = MasloYest2 + Teh_oglad2;
            combineMasloYest_Teh_oglad2(true);

            remont_kuzova2(true);
            Change_koles2a(true);

            disply2();


            List<Student> list = new List<Student>();

            list.Add(new Student("Лиза", "Жовниренко", 20));
            list.Add(new Student("Влад", "Калиш", 20));
            list.Add(new Student("Саша", "Гудков", 23));
            list.Add(new Student("Петров", "Петрович", 18));
            list.Add(new Student("Андрей", "Кузнечев", 33));
            list.Add(new Student("Саша", "Козирь", 20));


            List<Student> student = new List<Student>();
            StudentPredicateDelegate @delegate;


            @delegate = Student.Vozrast;
            student = list.FindStudent(@delegate);
            student.DisplayList();


            @delegate = Student.First;
            student = list.FindStudent(@delegate);
            student.DisplayList();


            @delegate = Student.First_Symbols;
            student = list.FindStudent(@delegate);
            student.DisplayList();


            @delegate = student => student.age >= 18 ? true : false;
            student = list.FindStudent(@delegate);
            student.DisplayList();


            @delegate = student => student.FirstName[0] == 'A' ? true : false;
            student = list.FindStudent(@delegate);
            student.DisplayList();


            @delegate = student => student.LastName.Length > 3 ? true : false;
            student = list.FindStudent(@delegate);
            student.DisplayList();



            @delegate = student => student.age > 20 && student.age < 25 ? true : false;
            student = list.FindStudent(@delegate);
            student.DisplayList();


            @delegate = student => student.FirstName == "Andrew" ? true : false;
            student = list.FindStudent(@delegate);
            student.DisplayList();


            @delegate = student => student.LastName == "Troelsen" ? true : false;
            student = list.FindStudent(@delegate);
            student.DisplayList();





        }
    }
}
