using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO
{
    public class Manager : Employee
    {


        public int StockOptions {get; set;}

        public Manager(string imie, string nazwisko, int age, double salary, int stock)
        {
            this.ID = GetNextId();
            this.FirstName = imie;
            this.SecondName = nazwisko;
            this.Age = age;
            this.Salary = salary;
            this.StockOptions = stock;
        }
        public Manager()
        {
            this.ID = GetNextId();
            this.FirstName = "Brak";
            this.SecondName = "Brak";
            this.Age = 0;
            this.Salary = 0;
            this.StockOptions = 0;
        }

        public override void GiveBonus(int bonus)
        {
            Random r = new Random();
            this.StockOptions += r.Next(500);
            base.GiveBonus(bonus + this.StockOptions);               
        }
        

              
       





    }
}
