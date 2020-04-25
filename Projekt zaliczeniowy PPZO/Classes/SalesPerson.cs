using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO.Classes
{
    class SalesPerson : Employee
    {
        public int SalesNumber {get; set;}

        public SalesPerson()
        {
            this.ID = GetNextId();
            this.FirstName = "Brak";
            this.SecondName = "Brak";
            this.Age = 0;
            this.Salary = 0;
            this.SalesNumber = 0;
        }
        public SalesPerson(string imie, string nazwisko, int age, double salary, int sales)
        {
            this.ID = GetNextId();
            this.FirstName = imie;
            this.SecondName = nazwisko;
            this.Age = age;
            this.Salary = salary;
            this.SalesNumber = sales;
        }
        public override void GiveBonus(int bonus)
        {
            Random r = new Random();
            this.SalesNumber = r.Next(100);
            int salesBonus = 0;
            if (this.SalesNumber > 50)
            {
                salesBonus = 5;
            }
            else
            {
                salesBonus = 3;
            }
            base.GiveBonus(bonus * salesBonus);
            
        }
    }
}
