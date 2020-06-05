using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_zaliczeniowy_PPZO.Classes
{
    //Autor: Norbert Olesiak-Zbieg, GL01, Informatyka 2 semestr - zaocznie
    //Klasa Sales Person definiująca sprzedawców
    class SalesPerson : Employee
    {
        //pole oznaczające ilość tranzakcji sprzedawcy
        public int SalesNumber { get; set; }


        //Konstruktor domyslny
        public SalesPerson()
        {
            this.ID = GetNextId();
            this.FirstName = "Brak";
            this.SecondName = "Brak";
            this.Age = 0;
            this.Salary = 0;
            this.SalesNumber = 0;
            this.Position = "SalesPerson";
        }
        //Konstruktor przeciązony
        public SalesPerson(string imie, string nazwisko, int age, double salary, int sales)
        {
            this.ID = GetNextId();
            this.FirstName = imie;
            this.SecondName = nazwisko;
            this.Age = age;
            this.Salary = salary;
            this.SalesNumber = sales;
            this.Position = "SalesPerson";
        }
        //Metoda giveBonus nadpisująca bazową metodę. Inaczej jest wyliczany bonus dla sprzedawcy
        public override void GiveBonus(int bonus)
        {
            // Random r = new Random();
            this.SalesNumber = 50;// r.Next(100);
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
