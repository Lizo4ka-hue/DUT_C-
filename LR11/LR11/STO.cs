using System;
using System.Collections.Generic;
using System.Text;

namespace LR11
{
    delegate void STo(bool be);
    
    delegate void Disply();
    
    class STO
    {
        private Car car1 { get; set; } = new Car();
        
      
        public void Rozval_shozdeny(bool be)
        {

            
            car1.Rozval_Shozdeny = be;
            

        }
        public void Painted(bool be)
        {
           
            car1.Painted = be;
        }
        public void MasloYest(bool be)
        {
           
            car1.MasloYest = be;
        }
        public void Teh_oglad(bool be)
        {
            
            car1.Teh_oglad = be;
        }
        public void Change_kolesa(bool be)
        {
            
            car1.Change_kolesa = be;
        }

        public void remont_kuzova(bool be)
        {
           
            car1.remont_kuzova = be;
        }
        public void DIsplay()
        {
            
            Console.WriteLine("Розвал схождения - " + car1.Rozval_Shozdeny + "\nПокраска- " + car1.Painted + "\nМасло Есть- " + car1.MasloYest + "\nТех-огляд- " + car1.Teh_oglad + "\nКолеса заменены- " + car1.Change_kolesa + "\nРемонт кузова- "+car1.remont_kuzova);
        }

        
    }
    class Car
    {
        public bool Rozval_Shozdeny { get; set; }
        public bool Painted { get; set; }
        public bool MasloYest { get; set; }
        public bool Teh_oglad { get; set; }
        public bool Change_kolesa { get; set; }
        public bool remont_kuzova { get; set; }

    }
}
